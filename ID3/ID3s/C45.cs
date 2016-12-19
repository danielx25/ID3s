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
    class C45: ID3_
    {
        private Tabla tabla = null;
        private Arbol_ arbolc45;
        private double promedioGanancia = 0;
        //public Nodo algoritmoC45()
        //{
        //    return null;
        //}

        public void cargarTablaC45(Tabla tabla)
        {
            this.tabla = tabla;
            arbolc45 = new Arbol_();
            promedioGanancia = promedioGanancias(this.tabla);
        }

        public void iniciarC45()
        {
            //inicio cronometro
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Restart();

            arbolc45.setRaiz(algoritmoC45(tabla, tabla.getClases()));
            System.Console.WriteLine(arbolc45);
            arbolc45.guardarArbol("arbol.txt");

            // termino cronometro + resultados C4.5
            stopwatch.Stop();
            TimeSpan tiempoC45 = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            tiempoC45.Hours, tiempoC45.Minutes, tiempoC45.Seconds,
            tiempoC45.Milliseconds / 10);
            string elapsedMilisecons = String.Format(" {0} ", tiempoC45.Milliseconds);
            Console.WriteLine("RunTime: " + elapsedTime);
            Console.WriteLine("Runtime: " + elapsedMilisecons + " miliseconds");
        }

        public Nodo algoritmoC45(Tabla tabla, List<String> atributos)
        {
            Nodo raiz = null;
            if (siTodosEjemplosSonLosMismos(tabla))
            {
                Columna columna = tabla.getColumnaAtributoSalida();
                String aSalida = (String)columna[0];
                raiz = new Nodo(aSalida);
                return raiz;
            }
            if (atributos.Count == 1)//si no existe ningun atributo
            {
                //elAtributoSAlidoMayorNumero()
                //el mayor numero de valor de salida
                raiz = new Nodo(elAtributoSAlidoMayorNumero(tabla));
                return raiz;
            }
            int indiceClase = this.seleccionarAtributoMayorRatio(tabla);
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
                    raiz.agregarNodo(algoritmoC45(nuevaTabla, nuevaTabla.getClases()));
                }
            }
            return raiz;
        }

        public double informacionDivision(Columna columna) // split information
        {
            List<string> atributos = columna.getAtributos();
            double divDeLaInformacion = 0.0;
            double probb = 0.0;

            //Console.WriteLine("clase: "+columna.getClase());
            for ( int i = 0; i < atributos.Count; i++ ) {
                //Console.WriteLine("infoDiv = ("+atributos[i]+")"+ columna.getFrecuenciaAtributo(atributos[i])+" / "+columna.getTam());
                probb = (double)((double)(columna.getFrecuenciaAtributo(atributos[i])) / (double)(columna.getTam()));
                //Console.WriteLine("probb = "+probb);
                divDeLaInformacion -= (double)(probb*(Math.Log(probb,2.0)));
            }
            //Console.WriteLine("Div de la info = "+divDeLaInformacion);
            return divDeLaInformacion;
        }

        public double ratioDeGanancia(Tabla tabla, Columna columna) //GainRatio
        {
            double Ganancia = (double)this.gananciaClase(columna, tabla.getColumnaAtributoSalida());
            double DivInformacion = (double)this.informacionDivision(columna);

            //Console.WriteLine("El ratio de ganancia es = " + (double)((double)Ganancia / (double)DivInformacion));

            if(Ganancia >= promedioGanancia)
            {
                return Ganancia;
            }
            else
            {
                return (double)((double)Ganancia / (double)DivInformacion);
            }
        }

        public double[] ratioDeCadaClase(Tabla tabla)
        {
            double[] ratios = new double[tabla.getCountColumna()-1];

            for (int i = 0; i < tabla.getCountColumna() - 1; i++)
            {
                //Console.WriteLine("Para clase {0}", i);
                //Console.WriteLine("Ratio=" + this.ratioDeGanancia(tabla, tabla.getColumna(i)));
                ratios[i] = ((double)this.ratioDeGanancia(tabla, tabla.getColumna(i)));
            }
            return ratios;
        }

        public int seleccionarAtributoMayorRatio(Tabla tabla) // retorna el indice de la columna
        {
            double[] ratios = this.ratioDeCadaClase(tabla);

            return Array.IndexOf(ratios, ratios.Max());
        }

        public double promedioGanancias(Tabla tabla)
        {
            double gananciaTotal = 0;
            for(int i=0; i<tabla.getCountColumna(); i++)
            {
                gananciaTotal+= (double)this.gananciaClase(tabla.getColumna(i), tabla.getColumnaAtributoSalida());
            }

            return gananciaTotal/(tabla.getCountColumna()-1);
        }
    }
}
