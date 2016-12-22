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
    public partial class RecorrerArbol : Form
    {
        private Nodo nodo = null;
        public RecorrerArbol(Arbol_ arbol)
        {
            InitializeComponent();
            clase.Text = arbol.Raiz.getNombreClase();
            List<string> strrs = arbol.Raiz.getAtributos();
            foreach (string valor in strrs)
            {
                atributos.Items.Add(valor);
            }
            nodo = arbol.Raiz;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void cargarArbol(Arbol_ arbol)
        {
            clase.Text = arbol.Raiz.getNombreClase();
           
        }

        public void recorrer(Nodo nodo1)
        {
            if (nodo1.getEsHoja() == true)
            {
                System.Console.WriteLine("ES HOJA: "+ nodo.getNombreClase());
                clase = new Label();
                //clase.Size = new System.Drawing.Size(10, 10);
                clase.Text = "prediccion: "+nodo1.getNombreClase();
                this.flowLayoutPanel1.Controls.Add(clase);
                //atributos = null;

            }
            else
            {
                clase = new Label();
                clase.Text = nodo1.getNombreClase();
                this.flowLayoutPanel1.Controls.Add(clase);
                atributos = new ComboBox();
                atributos.Size = new System.Drawing.Size(521, 21);
                List<string> strrs = nodo1.getAtributos();
                foreach (string valor in strrs)
                {
                    atributos.Items.Add(valor);
                }

                this.atributos.SelectedIndexChanged += new System.EventHandler(this.atributos_SelectedIndexChanged_1);

                this.flowLayoutPanel1.Controls.Add(atributos);
                
            }

            //tableLayoutPanel1.
        }


        private void atributos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            System.Console.WriteLine(atributos.SelectedItem);
            System.Console.WriteLine(atributos.FindStringExact((string)atributos.SelectedItem));
            int index = atributos.FindStringExact((string)atributos.SelectedItem);
            if (nodo[index].getEsHoja())
                flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count);
            recorrer(nodo[index]);
            if (!nodo[index].getEsHoja())
            {
                nodo = nodo[index];
            }
            
        }
    }
}
