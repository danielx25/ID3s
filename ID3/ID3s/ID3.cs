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
            String atributo = seleccionarAtributoConMayorGanancia(tabla, atributos_salida, atributos);
            return null;
        }

        public bool siTodosEjemplosSonLosMismos(Tabla tabla)
        {
            Columna columna = tabla.getColumnaAtributoSalida();
            String atributo;
            atributo = (String)columna[0];
            for (int i=1; i<columna.getTam(); i++)
            {
                System.Console.WriteLine(atributo + "---" + columna[i]);
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

        public String seleccionarAtributoConMayorGanancia(Tabla tabla, List<String> atributo_salida, List<String> atributos)
        {
            double ganancia_informacion = 0.0;
            double ganancia_atributo = 0.0;
            for(int i=0; i<atributos.Count; i++)
            {

            }

            return null;

        }

        public double entropiaGeneral(Columna atributoOjetivo)
        {
            List<String> atributos = atributoOjetivo.getAtributos();
            int[] contadorAtributos = new int[atributos.Count];

            for (int i = 0; i < atributoOjetivo.getTam(); i++)
            {
                String atributoC = (String)atributoOjetivo[i];

                for (int j = 0; j < atributos.Count; j++)
                {
                    if (String.Equals(atributoC, atributos[j], StringComparison.Ordinal))
                        contadorAtributos[j] += 1;
                }
            }

            double resultado = 0.0;

            for (int i = 0; i < contadorAtributos.Length; i++)
            {
                
                double division = (double)contadorAtributos[i] / atributoOjetivo.getTam();
                resultado +=-division* Math.Log(division, 2.0);
            }
            return resultado;
        }

        public double entropiaAtributo(Columna clase, Columna atributoOjetivo, String atributo)
        {
            List<String> atributos = atributoOjetivo.getAtributos();
            int[] contadorAtributos = new int[atributos.Count];
            int total = 0;

            for (int i = 0; i < atributoOjetivo.getTam(); i++)
            {
                String atributoS = (String)atributoOjetivo[i];
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

                double division = (double)contadorAtributos[i] / total;
                resultado=-division * (Math.Log(division)/Math.Log(2.0));
                System.Console.WriteLine(contadorAtributos[i]+"--"+ total+"--"+division+"= "+resultado);
            }
            return resultado;
        }

        public double gananciaInformacion(int columna, Tabla tabla)
        {
            return 0.0;
        }



    }
}
