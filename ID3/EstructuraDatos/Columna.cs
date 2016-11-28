using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID3.EstructuraDatos
{
    public class Columna
    {
        private List<string> atributos = null;
        private bool isContinuo = false;
        private ArrayList lista;

        private String clase;
        
        public Columna(String clase, int numFilas, bool isContinuo)
        {
            this.clase = clase;
            lista = new ArrayList();
            for (int i=0; i<numFilas; i++)
            {
                if (isContinuo == true)
                    lista.Add(0);
                else
                    lista.Add("none");
            }
        }

        public object this[int indice]
        {
            get
            {
                return lista[indice];
            }

            set
            {
                lista[indice] = value;
            }
        }

        public List<String> getAtributos()
        {
            return atributos;
        }

        public void addAtributo(List<String> attrs)
        {
            this.atributos = attrs;
        }

        public String getClase()
        {
            return this.clase;
        }

        public int getTam()
        {
            return lista.Count;
        }

        public int getCountAtributo(String atributo)
        {
            int contador = 0;
            for(int i=0; i<lista.Count;i++)
            {
                if(atributo.Equals(lista[i]))
                {
                    contador += 1;
                }
            }
            return contador;
        }

        protected void setValores(ArrayList array, List<string> atrr)
        {
            lista = new ArrayList(array);
            atributos = new List<string>(atrr);
        }

        public Columna Clone()
        {
            Columna columna = new Columna(this.clase, lista.Count, this.isContinuo);
            columna.setValores(lista, atributos);
            return columna;
        }

    }
}