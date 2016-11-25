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

            string root = @"C:\users";
            string root2 = @"C:\Users";

            // Use the overload of the Equals method that specifies a StringComparison.
            // Ordinal is the fastest way to compare two strings.
            bool result = String.Equals(root, root2, StringComparison.Ordinal);

            Console.WriteLine(resulto);

            Tabla tabla = farmaco();
            System.Console.ReadKey();

        }

        static Tabla farmaco()
        {
            Columna presionArterial = new Columna("presion arterial", 14, false);
            presionArterial.addAtributo(new List<String>{"baja", "media", "alta"});
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

            Columna azucarsAngre = new Columna("azucar sangre", 14, false);
            azucarsAngre.addAtributo(new List<String> { "bajo", "medio", "alto" });
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

            Columna indiceColesterol = new Columna("indice colesterol", 14, false);
            indiceColesterol.addAtributo(new List<String> { "bajo", "medio", "alto" });
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

            Columna alergiaAntibiotico = new Columna("alergia antibiotico", 14, false);
            alergiaAntibiotico.addAtributo(new List<String> { "si", "no" });
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

            Columna otrasAlergias = new Columna("otras alergias", 14, false);
            otrasAlergias.addAtributo(new List<String> { "si", "no" });
            otrasAlergias[0] = "si";
            otrasAlergias[1] = "si";
            otrasAlergias[2] = "si";
            otrasAlergias[3] = "no";
            otrasAlergias[4] = "no";
            otrasAlergias[5] = "si";
            otrasAlergias[6] = "si";
            otrasAlergias[7] = "si";
            otrasAlergias[8] = "no";
            otrasAlergias[9] = "si";
            otrasAlergias[10] = "si";
            otrasAlergias[11] = "no";
            otrasAlergias[12] = "si";
            otrasAlergias[13] = "si";

            Columna administrarFarmacos = new Columna("administrar farmacos", 14, false);
            administrarFarmacos.addAtributo(new List<String> { "si", "no" });
            administrarFarmacos[0] = "no";
            administrarFarmacos[1] = "no";
            administrarFarmacos[2] = "no";
            administrarFarmacos[3] = "si";
            administrarFarmacos[4] = "si";
            administrarFarmacos[5] = "si";
            administrarFarmacos[6] = "no";
            administrarFarmacos[7] = "si";
            administrarFarmacos[8] = "si";
            administrarFarmacos[9] = "si";
            administrarFarmacos[10] = "si";
            administrarFarmacos[11] = "si";
            administrarFarmacos[12] = "si";
            administrarFarmacos[13] = "no";

            Tabla tabla = new Tabla();
            tabla.agregarColumna(presionArterial);
            tabla.agregarColumna(azucarsAngre);
            tabla.agregarColumna(indiceColesterol);
            tabla.agregarColumna(alergiaAntibiotico);
            tabla.agregarColumna(otrasAlergias);
            tabla.agregarColumna(administrarFarmacos);

            return tabla;



        }
    }
}
