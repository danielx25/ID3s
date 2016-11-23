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
            Nodo raiz = new Nodo();
            if(siTodosEjemplosSonLosMismos(tabla))
            {
                //rellenar con el unico valor en la tabla
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
            return false;
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
