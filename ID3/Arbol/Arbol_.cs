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
    }
}
