using ID3.EstructuraDatos;
using ID3.ID3s;
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

            Tabla tabla = farmaco();
            ID3_ id3 = new ID3_();
            id3.cargarTabla(tabla);
            id3.iniciarID3();
            //System.Console.WriteLine(tabla);
            

            //System.Console.WriteLine(id3.siTodosEjemplosSonLosMismos(tabla));
            //System.Console.WriteLine(id3.elAtributoSAlidoMayorNumero(tabla));
            //System.Console.WriteLine(id3.entropiaGeneral(tabla.getColumnaAtributoSalida()));
            //System.Console.WriteLine(id3.seleccionarAtributoConMayorGanancia(tabla, new List<string> {"si", "no"}, tabla.getClases()));
            //System.Console.WriteLine(id3.entropiaAtributo(tabla.getColumna(7), tabla.getColumnaAtributoSalida(), "strong"));
            //System.Console.WriteLine(id3.gananciaClase(tabla.getColumna(0), tabla.getColumnaAtributoSalida()));
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
            administrarFarmacos[0] = "si";
            administrarFarmacos[1] = "si";
            administrarFarmacos[2] = "si";
            
            administrarFarmacos[3] = "no";
            administrarFarmacos[4] = "no";
            administrarFarmacos[5] = "si";
            administrarFarmacos[6] = "si";
            administrarFarmacos[7] = "si";
            administrarFarmacos[8] = "no";
            administrarFarmacos[9] = "si";
            administrarFarmacos[10] = "si";
            administrarFarmacos[11] = "no";
            administrarFarmacos[12] = "si";
            administrarFarmacos[13] = "si";

            

            Columna outlook = new Columna("outlook", 14, false);
            outlook.addAtributo(new List<String> { "sunny", "overcast", "rain" });
            outlook[0] = "sunny";
            outlook[1] = "sunny";
            outlook[2] = "overcast";
            outlook[3] = "rain";
            outlook[4] = "rain";
            outlook[5] = "rain";
            outlook[6] = "overcast";
            outlook[7] = "sunny";
            outlook[8] = "sunny";
            outlook[9] = "rain";
            outlook[10] = "sunny";
            outlook[11] = "overcast";
            outlook[12] = "overcast";
            outlook[13] = "rain";

            Columna temperature = new Columna("temperature", 14, false);
            temperature.addAtributo(new List<String> { "hot", "mild", "cool" });
            temperature[0] = "hot";
            temperature[1] = "hot";
            temperature[2] = "hot";
            temperature[3] = "mild";
            temperature[4] = "cool";
            temperature[5] = "cool";
            temperature[6] = "cool";
            temperature[7] = "mild";
            temperature[8] = "cool";
            temperature[9] = "mild";
            temperature[10] = "mild";
            temperature[11] = "mild";
            temperature[12] = "hot";
            temperature[13] = "mild";

            Columna humidity = new Columna("humidity", 14, false);
            humidity.addAtributo(new List<String> { "high", "normal"});
            humidity[0] = "high";
            humidity[1] = "high";
            humidity[2] = "high";
            humidity[3] = "high";
            humidity[4] = "normal";
            humidity[5] = "normal";
            humidity[6] = "normal";
            humidity[7] = "high";
            humidity[8] = "normal";
            humidity[9] = "normal";
            humidity[10] = "normal";
            humidity[11] = "high";
            humidity[12] = "normal";
            humidity[13] = "high";


            Columna wind = new Columna("wind", 14, false);
            wind.addAtributo(new List<String> { "weak", "strong" });
            wind[0] = "weak";
            wind[1] = "strong";
            wind[2] = "weak";
            wind[3] = "weak";
            wind[4] = "weak";
            wind[5] = "strong";
            wind[6] = "strong";
            wind[7] = "weak";
            wind[8] = "weak";
            wind[9] = "weak";
            wind[10] = "strong";
            wind[11] = "strong";
            wind[12] = "weak";
            wind[13] = "strong";


            Columna playBall = new Columna("playBall", 14, false);
            playBall.addAtributo(new List<String> { "yes", "no" });
            playBall[0] = "no";
            playBall[1] = "no";
            playBall[2] = "yes";
            playBall[3] = "yes";
            playBall[4] = "yes";
            playBall[5] = "no";
            playBall[6] = "yes";
            playBall[7] = "no";
            playBall[8] = "yes";
            playBall[9] = "yes";
            playBall[10] = "yes";
            playBall[11] = "yes";
            playBall[12] = "yes";
            playBall[13] = "no";
           

            Tabla tabla = new Tabla();
            /*
            tabla.agregarColumna(presionArterial);
            tabla.agregarColumna(azucarsAngre);
            tabla.agregarColumna(indiceColesterol);
            tabla.agregarColumna(alergiaAntibiotico);
            tabla.agregarColumna(otrasAlergias);
            tabla.agregarColumna(administrarFarmacos);*/
            tabla.agregarColumna(outlook);
            tabla.agregarColumna(temperature);
            tabla.agregarColumna(humidity);
            tabla.agregarColumna(wind);
            tabla.agregarColumna(playBall);

            Tabla tablaModificada = (Tabla)tabla.Clone();
            tablaModificada.eliminarColumna(0);
            System.Console.WriteLine("tabla: "+ tabla.getCountColumna());
            System.Console.WriteLine("tabla M: " + tablaModificada.getCountColumna());


            return tabla;



        }
    }
}
