﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID3.ID3s.EstructuraDatos
{
    public class Tabla
    {
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

        public int countCantidadClase(String valor)
        {
            Columna columna = tabla[tabla.Count - 1];
            int cantidad = 0;
            for (int i = 0; i < columna.getTam(); i++)
            {
                if (valor.Equals(columna[i]))
                    cantidad += 1;
            }
            return cantidad;
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

        public Columna getColumnaAtributoSalida() // clase
        {
            return tabla[tabla.Count - 1];
        }

        public int getCountColumna()
        {
            return tabla.Count;
        }

        public int getCountfilas()
        {
            return tabla[0].getTam();
        }

        public void eliminarColumna(int indice)
        {
            tabla.RemoveAt(indice);
            clases.RemoveAt(indice);
        }

        public void eliminarFilas(int indice)
        {
            for (int i = 0; i < tabla.Count; i++)
            {
                tabla[i].eliminarFila(indice);

            }
        }

        public override string ToString()
        {
            string cadena = "";


            for (int j = 0; j < this.getCountfilas(); j++)
            {
                for (int i = 0; i < tabla.Count; i++)
                {
                    System.Console.Write("|" + tabla[i][j] + "     |");
                }
                System.Console.WriteLine();
            }
            for (int j = 0; j < this.getCountColumna(); j++)
            {
                System.Console.WriteLine("clase: " + tabla[j].getClase());
                List<string> atributos = tabla[j].getAtributos();
                for(int i=0; i<atributos.Count; i++)
                {
                    System.Console.Write(atributos[i] + " - ");
                }
                System.Console.WriteLine();

            }
            return cadena;
        }

        public Tabla Clone()
        {
            Tabla nuevaTabla = new Tabla();

            for (int i = 0; i < tabla.Count; i++)
            {
                Columna columna = tabla[i].Clone();
                nuevaTabla.agregarColumna(columna);
            }
            return nuevaTabla;
        }
    }
}
