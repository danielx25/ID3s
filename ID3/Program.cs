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

            C45 c45 = new C45();
            Tabla tablac45 = animal();
            c45.cargarTablaC45(tablac45);
            c45.iniciarC45();

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


            Tabla tabla = animal();
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


        static Tabla creditos()
        {

            Columna riesgo = new Columna("riesgo", 14, false);
            riesgo.addAtributo(new List<string> { "alto", "moderado", "bajo" });
            riesgo[0] = "alto";
            riesgo[1] = "alto";
            riesgo[2] = "moderado";
            riesgo[3] = "alto";
            riesgo[4] = "bajo";
            riesgo[5] = "bajo";
            riesgo[6] = "alto";
            riesgo[7] = "moderado";
            riesgo[8] = "bajo";
            riesgo[9] = "bajo";
            riesgo[10] = "alto";
            riesgo[11] = "moderado";
            riesgo[12] = "bajo";
            riesgo[13] = "alto";

            Columna historia = new Columna("historia", 14, false);
            historia.addAtributo(new List<string> { "mala", "desconocida", "buena" });
            historia[0] = "mala";
            historia[1] = "desconocida";
            historia[2] = "desconocida";
            historia[3] = "desconocida";
            historia[4] = "desconocida";
            historia[5] = "desconocida";
            historia[6] = "mala";
            historia[7] = "mala";
            historia[8] = "buena";
            historia[9] = "buena";
            historia[10] = "buena";
            historia[11] = "buena";
            historia[12] = "buena";
            historia[13] = "mala";

            Columna deuda = new Columna("deuda", 14, false);
            deuda.addAtributo(new List<string> { "alta", "baja" });

            deuda[0] = "alta";
            deuda[1] = "alta";
            deuda[2] = "baja";
            deuda[3] = "baja";
            deuda[4] = "baja";
            deuda[5] = "baja";
            deuda[6] = "baja";
            deuda[7] = "baja";
            deuda[8] = "baja";
            deuda[9] = "alta";
            deuda[10] = "alta";
            deuda[11] = "alta";
            deuda[12] = "alta";
            deuda[13] = "alta";

            Columna avales = new Columna("avales", 14, false);
            avales.addAtributo(new List<string> { "adecuados", "no" });

            avales[0] = "no";
            avales[1] = "no";
            avales[2] = "no";
            avales[3] = "no";
            avales[4] = "no";
            avales[5] = "adecuados";
            avales[6] = "no";
            avales[7] = "adecuados";
            avales[8] = "no";
            avales[9] = "adecuados";
            avales[10] = "no";
            avales[11] = "no";
            avales[12] = "no";
            avales[13] = "no";

            Columna ingresos = new Columna("ingresos", 14, false);
            ingresos.addAtributo(new List<string> { "0 a 2m", "2 a 5m", "mas de 5m" });

            ingresos[0] = "0 a 2m";
            ingresos[1] = "2 a 5m";
            ingresos[2] = "2 a 5m";
            ingresos[3] = "0 a 2m";
            ingresos[4] = "mas de 5m";
            ingresos[5] = "mas de 5m";
            ingresos[6] = "0 a 2m";
            ingresos[7] = "mas de 5m";
            ingresos[8] = "mas de 5m";
            ingresos[9] = "mas de 5m";
            ingresos[10] = "0 a 2m";
            ingresos[11] = "2 a 5m";
            ingresos[12] = "mas de 5m";
            ingresos[13] = "2 a 5m";


            Tabla tabla = new Tabla();
            tabla.agregarColumna(riesgo);
            tabla.agregarColumna(historia);
            tabla.agregarColumna(deuda);
            tabla.agregarColumna(avales);
            tabla.agregarColumna(ingresos);

            return tabla;


        }


        static Tabla tratamiento()
        {

            Columna presion = new Columna("presion arterial", 14, false);
            presion.addAtributo(new List<string> { "alta", "normal", "baja" });
            presion[0] = "alta";
            presion[1] = "alta";
            presion[2] = "normal";
            presion[3] = "baja";
            presion[4] = "baja";
            presion[5] = "baja";
            presion[6] = "normal";
            presion[7] = "alta";
            presion[8] = "alta";
            presion[9] = "baja";
            presion[10] = "alta";
            presion[11] = "normal";
            presion[12] = "normal";
            presion[13] = "baja";

            Columna urea = new Columna("urea en sangre", 14, false);
            urea.addAtributo(new List<string> { "alta", "normal", "baja" });
            urea[0] = "alta";
            urea[1] = "alta";
            urea[2] = "alta";
            urea[3] = "normal";
            urea[4] = "baja";
            urea[5] = "baja";
            urea[6] = "baja";
            urea[7] = "normal";
            urea[8] = "baja";
            urea[9] = "normal";
            urea[10] = "normal";
            urea[11] = "normal";
            urea[12] = "alta";
            urea[13] = "normal";

            Columna gota = new Columna("gota", 14, false);
            gota.addAtributo(new List<string> { "si", "no" });

            gota[0] = "si";
            gota[1] = "si";
            gota[2] = "si";
            gota[3] = "si";
            gota[4] = "no";
            gota[5] = "no";
            gota[6] = "no";
            gota[7] = "si";
            gota[8] = "no";
            gota[9] = "no";
            gota[10] = "no";
            gota[11] = "si";
            gota[12] = "no";
            gota[13] = "si";

            Columna hipo = new Columna("hipotiroidismo", 14, false);
            hipo.addAtributo(new List<string> { "si", "no" });

            hipo[0] = "no";
            hipo[1] = "si";
            hipo[2] = "no";
            hipo[3] = "no";
            hipo[4] = "no";
            hipo[5] = "si";
            hipo[6] = "si";
            hipo[7] = "no";
            hipo[8] = "no";
            hipo[9] = "no";
            hipo[10] = "si";
            hipo[11] = "si";
            hipo[12] = "no";
            hipo[13] = "si";

            Columna admin = new Columna("administrar tratamiento", 14, false);
            admin.addAtributo(new List<string> { "si", "no" });

            admin[0] = "no";
            admin[1] = "no";
            admin[2] = "si";
            admin[3] = "si";
            admin[4] = "si";
            admin[5] = "no";
            admin[6] = "si";
            admin[7] = "no";
            admin[8] = "si";
            admin[9] = "si";
            admin[10] = "si";
            admin[11] = "si";
            admin[12] = "si";
            admin[13] = "no";


            Tabla tabla = new Tabla();
            tabla.agregarColumna(presion);
            tabla.agregarColumna(urea);
            tabla.agregarColumna(gota);
            tabla.agregarColumna(hipo);
            tabla.agregarColumna(admin);

            return tabla;


        }

        static Tabla animal() {

            Columna peludo = new Columna("peludo",8,false);
            peludo.addAtributo(new List<string> { "si", "no" });
            peludo[0] = "si";
            peludo[1] = "no";
            peludo[2] = "si";
            peludo[3] = "si";
            peludo[4] = "si";
            peludo[5] = "si";
            peludo[6] = "no";
            peludo[7] = "no";

            Columna edad = new Columna("edad", 8, false);
            edad.addAtributo(new List<string> { "viejo", "joven" });
            edad[0] = "viejo";
            edad[1] = "joven";
            edad[2] = "joven";
            edad[3] = "viejo";
            edad[4] = "joven";
            edad[5] = "joven";
            edad[6] = "joven";
            edad[7] = "viejo";

            Columna tamaño = new Columna("tamaño", 8, false);
            tamaño.addAtributo(new List<string> { "grande","mediano","pequeño"});

            tamaño[0] = "grande";
            tamaño[1] = "grande";
            tamaño[2] = "mediano";
            tamaño[3] = "pequeño";
            tamaño[4] = "pequeño";
            tamaño[5] = "grande";
            tamaño[6] = "pequeño";
            tamaño[7] = "grande";

            Columna clase = new Columna("clase", 8, false);
            clase.addAtributo(new List<string> { "leon", "no leon"});

            clase[0] = "leon";
            clase[1] = "no leon";
            clase[2] = "leon";
            clase[3] = "no leon";
            clase[4] = "no leon";
            clase[5] = "leon";
            clase[6] = "no leon";
            clase[7] = "no leon";

            Tabla tabla = new Tabla();
            tabla.agregarColumna(peludo);
            tabla.agregarColumna(edad);
            tabla.agregarColumna(tamaño);
            tabla.agregarColumna(clase);

            return tabla;


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
            azucarsAngre.addAtributo(new List<String> { "bajo", "alto" });
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
            indiceColesterol.addAtributo(new List<String> { "bajo", "alto" });
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

     
           

            Tabla tabla = new Tabla();
            tabla.agregarColumna(presionArterial);
            tabla.agregarColumna(azucarsAngre);
            tabla.agregarColumna(indiceColesterol);
            tabla.agregarColumna(alergiaAntibiotico);
            tabla.agregarColumna(otrasAlergias);
            tabla.agregarColumna(administrarFarmacos);


            return tabla;
        }

        static Tabla playball()
        {
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
            humidity.addAtributo(new List<String> { "high", "normal" });
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
            tabla.agregarColumna(outlook);
            tabla.agregarColumna(temperature);
            tabla.agregarColumna(humidity);
            tabla.agregarColumna(wind);
            tabla.agregarColumna(playBall);
            return tabla;
        }

        static Tabla transporte()
        {
            Columna gender = new Columna("gender", 10, false);
            gender.addAtributo(new List<String> { "male", "female"});
            gender[0] = "male";
            gender[1] = "male";
            gender[2] = "female";
            gender[3] = "female";
            gender[4] = "male";
            gender[5] = "male";
            gender[6] = "female";
            gender[7] = "female";
            gender[8] = "male";
            gender[9] = "female";

            Columna carOwnership = new Columna("carOwnership", 10, false);
            carOwnership.addAtributo(new List<String> { "0", "1", "2" });
            carOwnership[0] = "0";
            carOwnership[1] = "1";
            carOwnership[2] = "1";
            carOwnership[3] = "0";
            carOwnership[4] = "1";
            carOwnership[5] = "0";
            carOwnership[6] = "1";
            carOwnership[7] = "1";
            carOwnership[8] = "2";
            carOwnership[9] = "2";

            Columna travelCost = new Columna("travelCost", 10, false);
            travelCost.addAtributo(new List<String> { "cheap", "standard", "expensive"});
            travelCost[0] = "cheap";
            travelCost[1] = "cheap";
            travelCost[2] = "cheap";
            travelCost[3] = "cheap";
            travelCost[4] = "cheap";
            travelCost[5] = "standard";
            travelCost[6] = "standard";
            travelCost[7] = "expensive";
            travelCost[8] = "expensive";
            travelCost[9] = "expensive";

            Columna incomeLevel = new Columna("incomeLevel", 10, false);
            incomeLevel.addAtributo(new List<String> { "low", "medium", "high" });
            incomeLevel[0] = "low";
            incomeLevel[1] = "medium";
            incomeLevel[2] = "medium";
            incomeLevel[3] = "low";
            incomeLevel[4] = "medium";
            incomeLevel[5] = "medium";
            incomeLevel[6] = "medium";
            incomeLevel[7] = "high";
            incomeLevel[8] = "medium";
            incomeLevel[9] = "high";

            Columna transport = new Columna("transport", 10, false);
            transport.addAtributo(new List<String> { "bus", "train", "car" });
            transport[0] = "bus";
            transport[1] = "bus";
            transport[2] = "train";
            transport[3] = "bus";
            transport[4] = "bus";
            transport[5] = "train";
            transport[6] = "train";
            transport[7] = "car";
            transport[8] = "car";
            transport[9] = "car";

            Tabla tabla = new Tabla();
            tabla.agregarColumna(gender);
            tabla.agregarColumna(carOwnership);
            tabla.agregarColumna(travelCost);
            tabla.agregarColumna(incomeLevel);
            tabla.agregarColumna(transport);
            return tabla;
        }


    }
}
