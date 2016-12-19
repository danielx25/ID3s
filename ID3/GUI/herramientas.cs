using ID3.EstructuraDatos;
using ID3.ID3s;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ID3.GUI
{
    public partial class herramientas : Form
    {
        Leer l = new Leer();
        //Alamcena la ruta del archivo .txt
        public string ARCHIVO = "";

        public herramientas()
        {
            InitializeComponent();
           // AddFormInPanel3(new Ram());
        }

        //********************************************************************************************************************************

        public void cargarArchivo()
        {
            try
            {
                this.openFileDialog1.ShowDialog();

                if (!string.IsNullOrEmpty(this.openFileDialog1.FileName))
                {
                    ARCHIVO = this.openFileDialog1.FileName;
                    l.lecturaArchivo(dataGridView, ';', ARCHIVO);

                    labelVistaPrevia.Text = "          Vista Previa";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        //**********************************************************************************************************************

        private void btnImportar_Click(object sender, EventArgs e)
        {

            cargarArchivo();
                      
            herramientas he = new herramientas();
            C45 c45 = new C45();
            he.churn();
            c45.cargarTablaC45(he.churn());
            c45.iniciarC45();



        }

        //***************************************************************************************************************************

        

        //******************************************************************************************************************************

        public void rellenaMatriz()
        {

            string[,] Matriz = new string[dataGridView.Rows.Count, dataGridView.Columns.Count];

            int i = 0;
            int x = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                while (x < dataGridView.Columns.Count)
                {
                    Matriz[i, x] = row.Cells[x].Value != null ? row.Cells[x].Value.ToString() : string.Empty;
                    x++;

                }

                x = 0;
                i++;


            }
            for (int f = 0; f < dataGridView.Rows.Count; f++)
            {
                for (int c = 0; c < dataGridView.Columns.Count; c++)
                {
                    Console.Write(Matriz[f, c] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }  //finnn
        ///************************************************************************************************************************************

        public ArrayList Colum(int col) {

            ArrayList columna = new ArrayList();
            int c = 0;
            
            int Total = int.Parse(dataGridView.ColumnCount.ToString());

                                     
                    for (int i = 0; i < dataGridView.RowCount; i++)
                    {

                       
                        columna.Add(dataGridView.Rows[i].Cells[col].Value.ToString());
                       

                    }
                                       
            return columna;

        }

        //***************************************************************************************************************************************

        public int retornaFilas() {

            int Total = int.Parse(dataGridView.Rows.Count.ToString());

            return Total;
        }


        //***********************************************************************************************************************

        public ArrayList archivoCsv(int col, string hola){ // esta wea si sirve, pero ahi nomas  ,al final no la uso

           // openFileDialog1.ShowDialog();
            ArrayList Columna = new ArrayList();
                       
            using (var rd = new StreamReader(hola/*openFileDialog1.FileName*/))
            {
                while (!rd.EndOfStream)
                {
                    var splits = rd.ReadLine().Split(';');
                    Columna.Add(splits[col]);
                    //column2.Add(splits[0]);
                }
            }

            int i = 0;
           
            return Columna;
                        
        }

        //***************************************************************************************************************************

        public Tabla churn() {

            int Filas = retornaFilas();

            Columna estado_cliente = new Columna("estado_cliente", Filas, false);
            estado_cliente.addAtributo(new List<string> { "vigente", "inhavilitado","renuncia" });
            ArrayList columna1 = new ArrayList();
            columna1 = Colum(0);
            for (int i=0; i< Filas;i++) {

                estado_cliente[i] = columna1[i];
            }


            Columna nombre_segmento = new Columna("nombre_ segmento", Filas, false);
            nombre_segmento.addAtributo(new List<string> { "empresa", "persona" });
            ArrayList columna2 = new ArrayList();
            columna2 = Colum(1);
            for (int i = 0; i < Filas; i++)
            {

                nombre_segmento[i] = columna2[i];
            }

            Columna nombre_plan = new Columna("nombre_plan",Filas,false);
            nombre_plan.addAtributo(new List<string> { "linea comercial", "linea residencial","linea residencial desagregada","fast line" , "liena pabx analoga"});
            ArrayList columna3 = new ArrayList();
            columna3 = Colum(2);
            for (int i = 0; i < Filas; i++)
            {

                nombre_plan[i] = columna3[i];
            }

            Columna nombre_zonageo = new Columna("nombre_zonageo", Filas, false);
            nombre_zonageo.addAtributo(new List<string> { "santiago", "valparaiso","consepcion","valdivia", "pta arenas", "antofagasta", "iquique", "osorno", "coyahique", " talca", " la serena " , " temuco", " puerto mont"  });
            ArrayList columna4 = new ArrayList();
            columna4 = Colum(3);
            for (int i = 0; i < Filas; i++)
            {

                nombre_zonageo[i] = columna4[i];
            }

        
            Columna nombre_estadofianl = new Columna("nombre_estadofianl",Filas,false);
            nombre_estadofianl.addAtributo(new List<string> { "vigente", "inhabilitado", "renunciado" });
            ArrayList columna5 = new ArrayList();
            columna5 = Colum(4);
            for (int i = 0; i < Filas; i++)
            {

                nombre_estadofianl[i] = columna5[i];
            }
       
            Columna resolucion_reclamo = new Columna("resolucion_reclamo", Filas, false);
            resolucion_reclamo.addAtributo(new List<string> { "aprobado", "sin clasificar" , "rechazado "});
            ArrayList columna6 = new ArrayList();
            columna6 = Colum(5);
            for (int i = 0; i < Filas; i++)
            {

                resolucion_reclamo[i] = columna6[i];
            }

            Columna reclamo_tipo = new Columna("tipo_ reclamo", Filas, false);
            reclamo_tipo.addAtributo(new List<string> { "solicitud de servicio", "reclamo de facturacion", "solicitud de bloqueo", " solicitudes comerciales", " solicitudes de servicio", " reclamos comerciales ", " otras solicitudes" });
            ArrayList columna7 = new ArrayList();
            columna7 = Colum(6);
            for (int i = 0; i < Filas; i++)
            {

                reclamo_tipo[i] = columna7[i];
            }

            //int y = 0;
            //for (int r=0; r<Filas; r++) {

            //    Console.WriteLine(y++ +" " +estado_cliente[r]);
            //}

            
            Tabla tabla = new Tabla();
            tabla.agregarColumna(estado_cliente);
            tabla.agregarColumna(nombre_segmento);
            tabla.agregarColumna(nombre_plan);
            tabla.agregarColumna(nombre_zonageo);
            tabla.agregarColumna(nombre_estadofianl);
            tabla.agregarColumna(resolucion_reclamo);
            tabla.agregarColumna(reclamo_tipo);

            return tabla;

        }

        
    }

} 

            
