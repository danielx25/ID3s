using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID3.Tabla
{
    class Tabla
    {
        private int numFilas = 0;
        private int numColumna = 0;
        private List<String> clases;
        private List<Columna> tabla;


        public Tabla()
        {

        }


        public object this[int indice1, int indice2]
        {
            get
            {
                Columna columna = tabla[indice1];
                return columna[indice2];
            }

            set
            {
                Columna columna = tabla[indice1];
                columna[indice2] = value;
            }
        }

        public void addColumna(Columna columna)
        {
            tabla.Add(columna);
        }
    }
}
