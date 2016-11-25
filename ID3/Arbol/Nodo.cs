using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID3.Arbol
{
    class Nodo
    {
        private bool esHoja = false;
        private bool esContinuo = false;
        private String clase;
        private List<String> atributos;
        private double division;
        private List<Nodo> punteros = new List<Nodo>();


        Nodo(String clase, List<String> atributos)
        {
            this.clase = clase;
            this.atributos = atributos;
            esContinuo = false;
            punteros = new List<Nodo>();
        }

        Nodo(String atributo_salida)
        {
            clase = atributo_salida;
            esHoja = true;
            esContinuo = false;
            atributos = null;
            punteros = null;
        }

        Nodo(String clase, double division)
        {
            this.clase = clase;
            this.division = division;
            esContinuo = true;
            punteros = new List<Nodo>();
        }

        public void agregarNodo(Nodo nodo)
        {
            punteros.Add(nodo);
        }

        public Nodo getNodo(int i)
        {
            return punteros[i];
        }

        public Nodo getNodo(string atributo)
        {
            int i = atributos.IndexOf(atributo);
            return punteros[i];
        }
    }
}
