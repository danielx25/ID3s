using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID3.Arbol
{
    public class Arbol_
    {
        private Nodo raiz = null;
        private double tiempo = 0;
        private int profundidadArbol = 0;
        private int numeroHojas = 0;

        public void setRaiz(Nodo nodo)
        {
            raiz = nodo;
        }

        public void agregarNodo()
        {

        }

        public override string ToString()
        {
            mostrarArbol(raiz, "");
            return null;
        }

        public void mostrarArbol(Nodo nodo, string spacio)
        {
            System.Console.WriteLine(spacio+"nombre: " + nodo.getNombreClase());
            if (nodo.getEsHoja() == false)
            for(int i=0; i<nodo.getCountPuntero(); i++)
            {
                    List<String> atributos = nodo.getAtributos();
                Nodo nuevoNodo = (Nodo)nodo[i];
                System.Console.WriteLine(spacio + "  atrr:"+atributos[i]);
                mostrarArbol(nuevoNodo, spacio+"     ");
            }

        }

        public double Tiempo
        {
            set
            {
                tiempo = value;
            }

            get
            {
                return tiempo;
            }
        }

        public int ProfundidadArbol
        {
            set
            {
                profundidadArbol = value;
            }

            get
            {
                return profundidadArbol;
            }
        }

        public int NumeroHojas
        {
            set
            {
                numeroHojas = value;
            }

            get
            {
                return numeroHojas;
            }
        }


    }
}
