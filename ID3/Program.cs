
using ID3.Arbol;
using ID3.EstructuraDatos;
using ID3.GUI;
using ID3.ID3s;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ID3
{
    static class Program
    {
        public static Tabla leerCSV(string fileName)
        {
            var reader = new StreamReader(File.OpenRead(fileName));
            List<List<string>> tabla = new List<List<string>>();
            List<string> columna = null;
            bool filaInicial = false;
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');
                if (filaInicial == false)
                {
                    for (int i = 0; i < values.Length; i++)
                    {
                        columna = new List<string>();
                        tabla.Add(columna);
                    }

                    filaInicial = true;
                }

                for (int i = 0; i < values.Length; i++)
                {
                    tabla[i].Add(values[i]);
                }
            }
            Tabla tablaID3s = new Tabla();
            Columna columna1 = null;
            for (int i = 0; i < tabla.Count; i++)
            {
                for (int j = 0; j < tabla[i].Count; j++)
                {
                    if (j == 0)
                    {
                        columna1 = new Columna(tabla[i][j], tabla[i].Count - 1, false);
                    }
                    else
                        columna1[j - 1] = tabla[i][j];
                }
                tabla[i].RemoveAt(0);
                columna1.addAtributo(tabla[i].Distinct().ToList());
                tablaID3s.agregarColumna(columna1);
            }

            return tablaID3s;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //herramientas he = new herramientas();
            //C45 c45 = new C45();
            //he.churn();
            //c45.cargarTablaC45(he.churn());
            //c45.iniciarC45();

            /*
            C45 c45 = new C45();
            c45.cargarTablaC45(leerCSV("churn.csv"));
            c45.iniciarC45();
            
            LopezMantaras diego = new LopezMantaras();
            //Tabla tablaLM = farmaco();
            diego.cargarTablaLM(leerCSV("churn.csv"));
            diego.iniciarLM();
            */
            //System.Console.WriteLine(tablac45);

            //ID3_ id3 = new ID3_();
            //Console.WriteLine("La ganancia de la clase es c45: " + id3.gananciaClase(tablac45.getColumna(4), tablac45.getColumnaAtributoSalida()));
            //Console.WriteLine("RATIO DE CADA CLASE:");
            //for (int i = 0; i < tablac45.getCountColumna() - 1; i++)
            //{
            //    Console.WriteLine("Para clase {0}", i);
            //    Console.WriteLine("Ratio=" + c45.ratioDeGanancia(tablac45, tablac45.getColumna(i)));
            //}

            //////double[] ratios = c45.ratioDeCadaClase(tablac45);
            //////Console.WriteLine("estos son los RATIOSSSSSS!!!-------------------");
            //////for(int i = 0; i< ratios.Length; i++)
            //////{
            //////    Console.WriteLine("ratio: "+ratios[i]);
            //////    Console.ReadKey();
            //////}
            //////int MayorRatio = c45.seleccionarAtributoMayorRatio(tablac45);
            //////Console.WriteLine("el indice del atributo con mayor ratio es: "+MayorRatio);


            //Tabla tabla = farmaco();
            /*
            ID3_ id3 = new ID3_();
            id3.cargarTabla(Ejemplos.playballContinuo());
            id3.iniciarID3();
            */
            //System.Console.WriteLine(tabla);


            //System.Console.WriteLine(id3.siTodosEjemplosSonLosMismos(tabla));
            //System.Console.WriteLine(id3.elAtributoSAlidoMayorNumero(tabla));
            //System.Console.WriteLine(id3.entropiaGeneral(tabla.getColumnaAtributoSalida()));
            //System.Console.WriteLine(id3.seleccionarAtributoConMayorGanancia(tabla, new List<string> {"si", "no"}, tabla.getClases()));
            //System.Console.WriteLine(id3.entropiaAtributo(tabla.getColumna(7), tabla.getColumnaAtributoSalida(), "strong"));
            //System.Console.WriteLine(id3.gananciaClase(tabla.getColumna(0), tabla.getColumnaAtributoSalida()));
            System.Console.ReadKey();


            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

        }


        

    }

}
    

