using ID3.Arbol;
using ID3.EstructuraDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID3.ID3s
{
    public class ID3_
    {
        private Tabla tabla = null;
        private Arbol_ arbol;
        public void cargarTabla(Tabla tabla)
        {
            this.tabla = tabla;
            arbol = new Arbol_();
        }

        public void iniciarID3()
        {
            arbol.setRaiz(algoritmoID3(tabla, tabla.getClases()));
            System.Console.WriteLine(arbol);
            //Nodo s=algoritmoID3(this.tabla, tabla.getClases());
            //System.Console.WriteLine(s.getNombreClase());
        }
        
        public Nodo algoritmoID3(Tabla tabla, List<String> atributos)
        {
            Nodo raiz = null;
            if(siTodosEjemplosSonLosMismos(tabla))
            {
                Columna columna = tabla.getColumnaAtributoSalida();
                String aSalida = (String) columna[0];
                raiz = new Nodo(aSalida);
                return raiz;
            }
            if (atributos.Count == 0)//si no existe ningun atributo
            {
                //elAtributoSAlidoMayorNumero()
                //el mayor numero de valor de salida
                raiz = new Nodo(elAtributoSAlidoMayorNumero(tabla));
                return raiz;
            }
            int indiceClase = seleccionarAtributoConMayorGanancia(tabla, atributos, raiz);
            Columna clase = tabla.getColumna(indiceClase);
            List<String> atributosClase = clase.getAtributos();
            raiz = new Nodo(clase.getClase(), atributosClase); // el nodo viene a ser la "clase" y los atributos las ramas

            Tabla nuevaTabla = null;

            for (int i=0; i<atributosClase.Count; i++)
            {
                nuevaTabla = (Tabla)tabla.Clone();
                particionarTabla(nuevaTabla, indiceClase, atributosClase[i]);
                if(nuevaTabla.getCountfilas() ==0)//ejemplos estan vacios
                {
                    raiz.agregarNodo(new Nodo(elAtributoSAlidoMayorNumero(tabla)));
                }
                else
                { 
                    nuevaTabla.eliminarColumna(indiceClase);
                    raiz.agregarNodo(algoritmoID3(nuevaTabla, nuevaTabla.getClases()));
                }
            }
            return raiz;
        }

        public bool siTodosEjemplosSonLosMismos(Tabla tabla)
        {
            Columna columna = tabla.getColumnaAtributoSalida();
            String atributo;
            atributo = (String)columna[0];
            for (int i=1; i<columna.getTam(); i++)
            {
                if (String.Equals(atributo, (String)columna[i], StringComparison.Ordinal)==false)
                {
                    return false;
                }
            }
            return true;
        }

        public string elAtributoSAlidoMayorNumero(Tabla tabla)
        {
            Columna columna = tabla.getColumnaAtributoSalida();
            List<String> atributos = columna.getAtributos();
            int[] contadorAtributos = new int[atributos.Count];
            //atributo = (String)columna[0];



            for (int i = 0; i < columna.getTam(); i++)
            {
                String atributoC = (String)columna[i]; 
                for (int j=0; j<atributos.Count; j++)
                {
                    if (String.Equals(atributoC, atributos[j], StringComparison.Ordinal))
                        contadorAtributos[j] += 1; 
                }
            }

            int indice = Array.IndexOf(contadorAtributos, contadorAtributos.Max());

            return atributos[indice];
        }

        public int seleccionarAtributoConMayorGanancia(Tabla tabla, List<String> atributos, Nodo nodo)
        {
            double[] ganaciasClases = new double[tabla.getCountColumna() - 1];

            for(int i=0; i<tabla.getCountColumna()-1; i++)
            {
                ganaciasClases[i] = gananciaClase(tabla.getColumna(i), tabla.getColumnaAtributoSalida());
                System.Console.WriteLine("ganancia: "+ganaciasClases[i]);
            }
            int indice = Array.IndexOf(ganaciasClases, ganaciasClases.Max());
            //nodo.setGanancia(ganaciasClases.Max());
            return indice;
        }

        public double gananciaClase(Columna clase, Columna atributoObjetivo)
        {
            double resultado = 0.0;
            List<String> atributos = clase.getAtributos();
            double[] entropiaAtributos = new double[atributos.Count];
            double entropiaGeneral = this.entropiaGeneral(atributoObjetivo);

            for(int i=0; i<atributos.Count; i++)
            {
                entropiaAtributos[i] = entropiaAtributo(clase, atributoObjetivo, atributos[i]);
                resultado += -((double)clase.getCountAtributo(atributos[i]) /clase.getTam())*entropiaAtributos[i];
                System.Console.WriteLine(clase.getClase()+"|| "+atributos[i] + "===>"+((double)clase.getCountAtributo(atributos[i]) / clase.getTam()) * entropiaAtributos[i]);
                System.Console.WriteLine("ganancia: "+entropiaGeneral+" ---> "+resultado);
            }
            System.Console.WriteLine();
            resultado += entropiaGeneral;
            return resultado;
        }

        public double entropiaGeneral(Columna atributoObjetivo)
        {
            List<String> atributos = atributoObjetivo.getAtributos();
            int[] contadorAtributos = new int[atributos.Count];

            for (int i = 0; i < atributoObjetivo.getTam(); i++)
            {
                String atributoC = (String)atributoObjetivo[i];

                for (int j = 0; j < atributos.Count; j++)
                {
                    if (String.Equals(atributoC, atributos[j], StringComparison.Ordinal))
                        contadorAtributos[j] += 1;
                }
            }

            double resultado = 0.0;

            for (int i = 0; i < contadorAtributos.Length; i++)
            {
                
                double division = (double)contadorAtributos[i] / atributoObjetivo.getTam();
                if (division>0)
                resultado +=-division* Math.Log(division, 2.0);
            }
            return resultado;
        }

        public double entropiaAtributo(Columna clase, Columna atributoObjetivo, String atributo)
        {
            List<String> atributos = atributoObjetivo.getAtributos();
            int[] contadorAtributos = new int[atributos.Count];
            int total = 0;

            for (int i = 0; i < atributoObjetivo.getTam(); i++)
            {
                String atributoS = (String)atributoObjetivo[i];
                String atributoC = (String)clase[i];

                for (int j = 0; j < atributos.Count; j++)
                {
                    if (String.Equals(atributoS, atributos[j], StringComparison.Ordinal) && String.Equals(atributoC, atributo, StringComparison.Ordinal))
                    {
                        contadorAtributos[j] += 1;
                        total += 1;
                    }
                        
                }
            }

            double resultado = 0.0;

            for (int i = 0; i < contadorAtributos.Length; i++)
            {

                double division = (contadorAtributos[i] / (double)total);
                if(division>0)
                resultado+=(-division) * (Math.Log(division)/Math.Log(2.0));
                System.Console.WriteLine("resultado: "+ resultado);
                System.Console.WriteLine("              ====> " + division+ " ["+ contadorAtributos[i] + "]/"+ " [" + total+ "]");
            }
            return resultado;
        }

        public void particionarTabla(Tabla tabla, int indiceClase, String atributo)
        {
            Columna clase = tabla.getColumna(indiceClase);

            for (int i = 0; i < clase.getTam(); i++)
            {
                String cadena = (String)clase[i];
                if (cadena.Equals(atributo) == false)
                {
                    tabla.eliminarFilas(i);
                    i -= 1;
                }
            }
        }

    }
}
