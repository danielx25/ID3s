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
        private List<String> atributos_salida = null;
        private List<String> atributos = null;
        private Tabla tabla = null;
        
        public Nodo algoritmoID3(Tabla tabla, List<String> atributo_salida, List<String> atributos)
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
            int indiceClase = seleccionarAtributoConMayorGanancia(tabla, atributos_salida, atributos);
            Columna clase = tabla.getColumna(indiceClase);
            List<String> atributosClase = clase.getAtributos();

            for (int i=0; i<atributosClase.Count; i++)
            {
                tabla = particionarTabla(tabla, clase, atributosClase[i]);
                if(tabla.getCountfilas() ==0)//ejemplos estan vacios
                {
                    raiz = new Nodo(elAtributoSAlidoMayorNumero(tabla));
                    return raiz;
                }
                else
                {
                    Tabla nuevaTabla = (Tabla)tabla.Clone();
                    nuevaTabla.eliminarColumna(indiceClase);
       
                    return algoritmoID3(tabla, atributo_salida, nuevaTabla.getClases());
                }
            }
            return null;
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

        public int seleccionarAtributoConMayorGanancia(Tabla tabla, List<String> atributo_salida, List<String> atributos)
        {
            double[] ganaciasClases = new double[tabla.getCountColumna() - 1];

            for(int i=0; i<tabla.getCountColumna()-1; i++)
            {
                ganaciasClases[i] = gananciaClase(tabla.getColumna(i), tabla.getColumnaAtributoSalida());
                System.Console.WriteLine(ganaciasClases[i]);
            }
            int indice = Array.IndexOf(ganaciasClases, ganaciasClases.Max());
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

                double division = contadorAtributos[i] / (double)total;
                if(division>0)
                resultado+=-division * (Math.Log(division)/Math.Log(2.0));
                //System.Console.WriteLine("              ====> " + division+ " ["+ contadorAtributos[i] + "]/"+ " [" + total+ "]");
            }
            return resultado;
        }

        public Tabla particionarTabla(Tabla tabla, Columna clase, String atributo)
        {
            return null;
        }

    }
}
