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

            Columna indiceColesterol = new Columna(14, false);
            indiceColesterol[0] = "alto";
            indiceColesterol[1] = "alto";
            indiceColesterol[2] = "bajo";
            indiceColesterol[3] = "alto";
            indiceColesterol[4] = "alto";
            indiceColesterol[5] = "alto";
            indiceColesterol[6] = "alto";
            indiceColesterol[7] = "bajo";
            indiceColesterol[8] = "bajo";
            indiceColesterol[9] = "alto";
            indiceColesterol[10] = "bajo";
            indiceColesterol[11] = "alto";
            indiceColesterol[12] = "alto";
            indiceColesterol[13] = "bajo";

            Columna alergiaAntibiotico = new Columna(14, false);
            alergiaAntibiotico[0] = "no";
            alergiaAntibiotico[1] = "si";
            alergiaAntibiotico[2] = "no";
            alergiaAntibiotico[3] = "no";
            alergiaAntibiotico[4] = "si";
            alergiaAntibiotico[5] = "si";
            alergiaAntibiotico[6] = "si";
            alergiaAntibiotico[7] = "no";
            alergiaAntibiotico[8] = "si";
            alergiaAntibiotico[9] = "si";
            alergiaAntibiotico[10] = "si";
            alergiaAntibiotico[11] = "si";
            alergiaAntibiotico[12] = "si";
            alergiaAntibiotico[13] = "no";

            Columna otrasAlergias = new Columna(14, false);
            otrasAlergias[0] = "no";
            otrasAlergias[1] = "no";
            otrasAlergias[2] = "no";
            otrasAlergias[3] = "si";
            otrasAlergias[4] = "si";
            otrasAlergias[5] = "si";
            otrasAlergias[6] = "no";
            otrasAlergias[7] = "si";
            otrasAlergias[8] = "si";
            otrasAlergias[9] = "si";
            otrasAlergias[10] = "si";
            otrasAlergias[11] = "si";
            otrasAlergias[12] = "si";
            otrasAlergias[13] = "no";



        }
    }
}
