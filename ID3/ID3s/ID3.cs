using ID3.Arbol;
using ID3.EstructuraDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID3.ID3s
{
    class ID3
    {
        private List<String> atributos_salida = null;
        private List<String> atributos = null;
        private Tabla tabla = null;
        
        public Nodo AlgoritmoID3(Tabla tabla, List<String> atributo_salida, List<String> atributos)
        {
            Nodo raiz = null;
            if(siTodosEjemplosSonLosMismos(tabla))
            {
                //rellenar con el unico valor en la tabla
                //raiz = Nodo();
                return raiz;
            }
            if (atributos.Count == 0)//si no existe ningun atributo
            {
                //elAtributoSAlidoMayorNumero()
                //el mayor numero de valor de salida
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
                if (String.Equals(atributo, (String)columna[i], StringComparison.Ordinal)==false)
                {
                    return false;
                }
            }
            return true;
        }

        public string elAtributoSAlidoMayorNumero(Tabla tabla)
        {
            return null;
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

        public double gananciaInformacion(int columna, Tabla tabla)
        {
            return 0.0;
        }



    }
}
