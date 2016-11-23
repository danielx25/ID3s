using ID3.EstructuraDatos;
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

        static void farmaco()
        {
            Columna presionArterial = new Columna(14, false);
            presionArterial[0] = "alta";
            presionArterial[1] = "alta";
            presionArterial[2] = "baja";
            presionArterial[3] = "media";
            presionArterial[4] = "media";
            presionArterial[5] = "baja";
            presionArterial[6] = "alta";
            presionArterial[7] = "alta";
            presionArterial[8] = "alta";
            presionArterial[9] = "baja";
            presionArterial[10] = "media";
            presionArterial[11] = "alta";
            presionArterial[12] = "baja";
            presionArterial[13] = "baja";

            Columna azucarsAngre = new Columna(14, false);
            azucarsAngre[0] = "alto";
            azucarsAngre[1] = "alto";
            azucarsAngre[2] = "alto";
            azucarsAngre[3] = "alto";
            azucarsAngre[4] = "bajo";
            azucarsAngre[5] = "bajo";
            azucarsAngre[6] = "bajo";
            azucarsAngre[7] = "bajo";
            azucarsAngre[8] = "alto";
            azucarsAngre[9] = "bajo";
            azucarsAngre[10] = "bajo";
            azucarsAngre[11] = "bajo";
            azucarsAngre[12] = "alto";
            azucarsAngre[13] = "alto";
        }
    }
}
