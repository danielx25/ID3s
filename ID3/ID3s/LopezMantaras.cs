using ID3.EstructuraDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID3.ID3s
{
    class LopezMantaras :ID3_
    {

        public static double EntropiaPorAtributoIJ()
        {
            return 0;
        }

        public static double ProbabilidadI(int numeroEventosI, int numeroEventosTotalesI)
        {
            return (double)(numeroEventosI / numeroEventosTotalesI);
        }

        public static double ProbabilidadInterseccionIJ(double probabilidadI, double probabilidadJ)
        {
            return (double)(probabilidadI * probabilidadJ);
        }

        public static double EntropiaInterseccionDeDosParticiones(Tabla tablaA, Tabla tablaB)
        {
            Columna columnaA = tablaA.getColumnaAtributoSalida();
            Columna columnaB = tablaB.getColumnaAtributoSalida();

            int[] contadorAtributosA = new int[columnaA.getAtributos().Count];
            int[] contadorAtributosB = new int[columnaB.getAtributos().Count];

            List<string> atributosA = columnaA.getAtributos();
            List<string> atributosB = columnaB.getAtributos();

            for (int i=0; i<columnaA.getcountAtributos(); i++)
            {
                contadorAtributosA[i] = columnaA.getFrecuenciaAtributo(atributosA[i]);
            }

            for (int i = 0; i < columnaB.getcountAtributos(); i++)
            {
                contadorAtributosB[i] = columnaB.getFrecuenciaAtributo(atributosB[i]);
            }


            for (int i = 0; i < 0; i++)
            {
                for (int j = 0; j <0 ; j++)
                {

                }
            }

            return 0;
        }

    }
}
