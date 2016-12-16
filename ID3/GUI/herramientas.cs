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
            int Total = int.Parse(dataGridView.ColumnCount.ToString());
            ArrayList nose = new ArrayList();

            /*cargarArchivo();
            Colum(0);
            Colum(1);
            Colum(2);*/
            openFileDialog1.ShowDialog();
            string Direcion = openFileDialog1.FileName;

            Colum();


            for (int i=0; i<6;i++) { //falta poner la cantidad de columnas

                archivoCsv(i, Direcion);
            }


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

        public ArrayList Colum() {

            ArrayList columna = new ArrayList();
            //Columna cl = new Columna();
            
            int Total = int.Parse(dataGridView.ColumnCount.ToString());

                                     
                    for (int i = 0; i < dataGridView.RowCount; i++)
                    {

                        //columna.Add(dataGridView.Rows[i].Cells[r].Value.ToString());
                        // columna.Add(dataGridView.Rows[i].Cells[col].Value.ToString());

                        columna.Add(dataGridView.Rows[i].Cells[0].Value.ToString());
                        Console.WriteLine(columna[i]);

                    }

                    Console.WriteLine("\n");
            
                    
            return columna;

        }
        //***********************************************************************************************************************

        public ArrayList archivoCsv(int col, string hola){ // esta wea si sirve, pero ahi nomas 

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
            // Console.WriteLine("Column 1:");
            foreach (var element in Columna)

                Console.WriteLine(i++ +" "+ element);
               
            Console.WriteLine("\n");

            return Columna;
                        
        }

        //***************************************************************************************************************************

        public   DataTable leerCsv() {   // esta wea no sirve 

            openFileDialog1.ShowDialog();

            StreamReader sr = new StreamReader(openFileDialog1.FileName);
            string[] headers = sr.ReadLine().Split(',');
            DataTable dt = new DataTable();
            foreach (string header in headers)
            {
                dt.Columns.Add(header);
            }
            while (!sr.EndOfStream)
            {
                string[] rows = Regex.Split(sr.ReadLine(), ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
                DataRow dr = dt.NewRow();
                for (int i = 0; i < headers.Length; i++)
                {
                    dr[i] = rows[i];
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        //************************************************************************************************************************************

    }

} 

            
