using ID3.Tabla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ID3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            System.Console.WriteLine("#########-------ID3-------########");
            
            Columna columna = new Columna(5, true);
            for(int i=0; i<5; i++)
            {
                //System.Console.WriteLine(columna[i]);
                columna[i] = i + 1;
            }
            System.Console.ReadKey();

        }
    }
}
