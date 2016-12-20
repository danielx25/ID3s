using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID3.Arbol
{
    [Serializable]
    public class Arbol_
    {
        private string nombreAlgortimo = "ID3s";
        private Nodo raiz = null;
        private double tiempo = 0;
        private int profundidadArbol = 0;
        private int numeroHojas = 0;
        private int numeroNodos = 0;

        public Arbol_(string nombreAlgoritmo1)
        {
            this.nombreAlgortimo = nombreAlgoritmo1;
        }

        public void setRaiz(Nodo nodo)
        {
            raiz = nodo;
        }

        public string NombreAlgoritmo
        {
            get
            {
                return nombreAlgortimo;
            }
        }

        public void agregarNodo()
        {

        }

        public override string ToString()
        {
            List<string> lista = new List<string>();
            mostrarArbol(raiz, "", lista);
            foreach(string linea in lista)
            {
                System.Console.Write(linea);
            }
            return null;
        }

        public void mostrarArbol(Nodo nodo, string spacio, List<string> lista)
        {
            //System.Console.WriteLine(spacio+"nombre: " + nodo.getNombreClase());
            lista.Add(spacio + "nombre: " + nodo.getNombreClase()+"\n");
            if (nodo.getEsHoja() == false)
            for(int i=0; i<nodo.getCountPuntero(); i++)
            {
                List<String> atributos = nodo.getAtributos();
                Nodo nuevoNodo = (Nodo)nodo[i];
                //System.Console.WriteLine(spacio + "  atrr:"+atributos[i]);
                lista.Add(spacio + "  atrr:" + atributos[i]+"\n");
                mostrarArbol(nuevoNodo, spacio+"     ", lista);
            }

        }
        public void analisisArbol()
        {
            numeroHojas = 0;
            numeroNodos = 0;
            analisisArbol(raiz, 0);
        }
        private void analisisArbol(Nodo nodo, int nivel)
        {
            numeroNodos += 1;
            nivel += 1;
            if (nodo.getEsHoja() == false)
                for (int i = 0; i < nodo.getCountPuntero(); i++)
                {
                    analisisArbol((Nodo)nodo[i], nivel);
                }
            else
            {
                if (profundidadArbol < nivel)
                    profundidadArbol = nivel;
                numeroHojas += 1;
            }
        }

        public int NumeroNodos
        {
            get
            {
                return numeroNodos;
            }
        }

        public void produccionReglas(Nodo nodo,  List<string> lista)
        {
            /*
            if (!nodo.getEsHoja())
                lista.Add(" AND "+nodo.getNombreClase() + " == ");
            else
                lista.Add(" THEN VALUE = "+)*/
            if (nodo.getEsHoja() == false)
                for (int i = 0; i < nodo.getCountPuntero(); i++)
                {
                    List<String> atributos = nodo.getAtributos();
                    Nodo nuevoNodo = (Nodo)nodo[i];
                    if (nuevoNodo.getEsHoja())
                    lista.Add( "  atrr:" + atributos[i] + "\n");
                    produccionReglas (nuevoNodo, lista);
                }
            else
            {

            }
        }
        public Nodo Raiz
        {
            get
            {
                return raiz;
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

        public void guardarArbol(string fileName)
        {
            
                TextWriter tw = new StreamWriter(fileName, true);
                List<string> lista = new List<string>();
                mostrarArbol(raiz, "", lista);
                foreach (string linea in lista)
                {
                    tw.Write(linea);
                }
                
                tw.Close();
            
        }


    }
}
