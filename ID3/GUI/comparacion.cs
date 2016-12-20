using ID3.Arbol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ID3.GUI
{
    public partial class comparacion : Form
    {
        public comparacion()
        {
            InitializeComponent();
        }

        public void agregarArbol(Arbol_[] arboles)
        {
            tablaComparacion.ColumnCount = arboles.Length;
            tablaComparacion.RowHeadersWidth = 200;
            Arbol_ arbol = null;
            for (int i = 0; i < arboles.Length; i++)
            {
                arbol = arboles[i];
                tablaComparacion.Columns[i].Name = arbol.NombreAlgoritmo;
            }
            List<List<string>> lista = new List<List<string>>();
            for (int i = 0; i < arboles.Length; i++)
            {
                arbol = arboles[i];
                List<string> columna = new List<string>();
                columna.Add(arbol.Tiempo.ToString());
                columna.Add(arbol.ProfundidadArbol.ToString());
                columna.Add(arbol.NumeroHojas.ToString());
                columna.Add(arbol.NumeroNodos.ToString());
                columna.Add(arbol.Raiz.getNombreClase());
                lista.Add(columna);
            }
            string[] nombres = new string[] {"tiempo (milisegundos)", "profundidad arbol", "numero de hojas", "numero de nodos", "atributo raiz"};
            for (int i = 0; i < 5; i++)
            {
                string[] row = new string[lista.Count];
                for (int j = 0; j < lista.Count; j++)
                {
                    row[j] = lista[j][i];
                    System.Console.Write("- "+ lista[j][i]);
                }
                System.Console.WriteLine();
                
                tablaComparacion.Rows.Add(row);
                tablaComparacion.Rows[i].HeaderCell.Value = nombres[i];
            }
        }
    }
}
