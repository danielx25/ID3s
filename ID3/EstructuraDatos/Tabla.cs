using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID3.EstructuraDatos
{
    public class Tabla
    {
        private int numFilas = 0;
        private int numColumna = 0;
        private List<String> clases;
        private List<Columna> tabla;


        public Tabla()
        {
            clases = new List<string>();
            tabla = new List<Columna>();
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

        public List<String> getClases()
        {
            return clases;
        }

        public void agregarColumna(Columna columna)
        {
            tabla.Add(columna);
            clases.Add(columna.getClase());
        }

        public Columna getColumna(int indice)
        {
            return tabla[indice];
        }

        public Columna getColumnaAtributoSalida()
        {
            return tabla[tabla.Count - 1];
        }

        public int getCountColumna()
        {
            return tabla.Count; 
        }
    }
}
