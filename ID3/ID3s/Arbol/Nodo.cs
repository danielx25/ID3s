using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID3.ID3s.Arbol
{
    public class Nodo
    {
        private bool esHoja = false;
        private bool esContinuo = false;
        private String clase;
        private List<String> atributos;
        private double division;
        private List<Nodo> punteros = new List<Nodo>();

        private double radioGanacia = 0.0;
        private double ganancia = 0.0;
        private double distancia = 0.0;

        public Nodo(String clase, List<String> atributos)
        {
            this.clase = clase;
            this.atributos = atributos;
            esContinuo = false;
            punteros = new List<Nodo>();
        }

        public Nodo(String atributo_salida)
        {
            clase = atributo_salida;
            esHoja = true;
            esContinuo = false;
            atributos = null;
            punteros = null;
        }

        public Nodo(String clase, double division)
        {
            this.clase = clase;
            this.division = division;
            esContinuo = true;
            punteros = new List<Nodo>();
        }

        public object this[int indice]
        {
            get
            {
                return punteros[indice];
            }

            set
            {
            }
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

        public String getNombreClase()
        {
            return clase;
        }

        public bool getEsHoja()
        {
            return this.esHoja;
        }

        public int getCountPuntero()
        {
            return punteros.Count();
        }

        public List<String> getAtributos()
        {
            return atributos;
        }

        public void setGanancia(double ganancia)
        {
            this.ganancia = ganancia;
        }
    }
}
