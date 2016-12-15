using ID3.Arbol;
using ID3.EstructuraDatos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID3.ID3s
{
    class LopezMantaras :ID3_
    {
        private Tabla tabla = null;
        private Arbol_ arbol;

        public void cargarTablaLM(Tabla tabla)
        {
            this.tabla = tabla;
            arbol = new Arbol_();
        }

        public void iniciarLM()
        {
            //inicio cronometro
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Restart();

            arbol.setRaiz(algoritmoLopezMataras(tabla, tabla.getClases()));
            System.Console.WriteLine(arbol);
            //Nodo s=algoritmoID3(this.tabla, tabla.getClases());
            //System.Console.WriteLine(s.getNombreClase());

            // termino cronometro + resultados LM
            stopwatch.Stop();
            TimeSpan tiempoLM = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            tiempoLM.Hours, tiempoLM.Minutes, tiempoLM.Seconds,
            tiempoLM.Milliseconds / 10);
            string elapsedMilisecons = String.Format(" {0} ", tiempoLM.Milliseconds);
            Console.WriteLine("RunTime: " + elapsedTime);
            Console.WriteLine("Runtime: " + elapsedMilisecons + " miliseconds");
        }
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

            for (int i=0; i<columnaA.getCountAtributos(); i++)
            {
                contadorAtributosA[i] = columnaA.getFrecuenciaAtributo(atributosA[i]);
            }

            for (int i = 0; i < columnaB.getCountAtributos(); i++)
            {
                contadorAtributosB[i] = columnaB.getFrecuenciaAtributo(atributosB[i]);
            }

            double entropiaInterseccion = 0;
            double probabilidadInterseccion = 0;
            for (int i = 0; i < atributosA.Count; i++)
            {
                for (int j = 0; j <atributosB.Count; j++)
                {
                    probabilidadInterseccion = ProbabilidadInterseccionIJ(ProbabilidadI(contadorAtributosA[i], columnaA.getTam()),
                        ProbabilidadI(contadorAtributosB[j], columnaB.getTam()));
                    entropiaInterseccion += -probabilidadInterseccion*Math.Log(probabilidadInterseccion,2);
                }
            }

            return probabilidadInterseccion;
        }

        public double distanciaLopezMataras(Tabla tablaA, Tabla tablaB)
        {
            double eGeneralA = entropiaGeneral(tablaA.getColumnaAtributoSalida());
            double eGeneralB = entropiaGeneral(tablaB.getColumnaAtributoSalida());

            return 2.0-(double)((eGeneralA+eGeneralB)/EntropiaInterseccionDeDosParticiones(tablaA, tablaB));
        }

        public List<double> calcularDistanciaConTodaParticiones(Tabla tabla)
        {
            Columna columna = null;
            Tabla nuevaTabla = null;
            List<string> atributos = null;

            double distancia = 0;
            List<double> distancias = new List<double>();

            for (int i=0; i<tabla.getCountColumna()-1; i++)
            {
                columna = tabla.getColumna(i);
                atributos = columna.getAtributos();
                distancia = 0;
                for (int j=0; j<atributos.Count; j++)
                {
                    nuevaTabla = (Tabla)tabla.Clone();
                    particionarTabla(nuevaTabla, i, atributos[j]);
                    distancia += distanciaLopezMataras(tabla, nuevaTabla);
                }
                distancias.Add(distancia);
            }

            return distancias;
        }

        public int seleccionarMinDistancia(List<double> distancias)
        {
            return Array.IndexOf(distancias.ToArray(), distancias.Min());
        }

        public Nodo algoritmoLopezMataras(Tabla tabla, List<String> atributos)
        {
            Nodo raiz = null;
            if (siTodosEjemplosSonLosMismos(tabla))
            {
                Columna columna = tabla.getColumnaAtributoSalida();
                String aSalida = (String)columna[0];
                raiz = new Nodo(aSalida);
                return raiz;
            }
            if (atributos.Count == 0)//si no existe ningun atributo
            {
                //elAtributoSAlidoMayorNumero()
                //el mayor numero de valor de salida
                raiz = new Nodo(elAtributoSAlidoMayorNumero(tabla));
                return raiz;
            }
            int indiceClase = seleccionarMinDistancia(calcularDistanciaConTodaParticiones(tabla));
            Columna clase = tabla.getColumna(indiceClase);
            List<String> atributosClase = clase.getAtributos();
            raiz = new Nodo(clase.getClase(), atributosClase); // el nodo viene a ser la "clase" y los atributos las ramas

            Tabla nuevaTabla = null;

            for (int i = 0; i < atributosClase.Count; i++)
            {
                nuevaTabla = (Tabla)tabla.Clone();
                particionarTabla(nuevaTabla, indiceClase, atributosClase[i]);
                if (nuevaTabla.getCountfilas() == 0)//ejemplos estan vacios
                {
                    raiz.agregarNodo(new Nodo(elAtributoSAlidoMayorNumero(tabla)));
                }
                else
                {
                    nuevaTabla.eliminarColumna(indiceClase);
                    raiz.agregarNodo(algoritmoID3(nuevaTabla, nuevaTabla.getClases()));
                }
            }
            return raiz;
        }

    }
}
