using ID3.Ficheros;
using ID3.GUI;
using ID3.ID3s;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ID3
{
    public partial class Inicio : Form
    {
        public string usuario;
        public int NumeroArbol;

        comparacion comparacionA = new comparacion();
        C45 c45 = new C45();
        LopezMantaras diego = new LopezMantaras();
        ID3_ id3 = new ID3_();
        herramientas herra = new herramientas();

        

        public Inicio()
        {
            InitializeComponent();
            button1.Location = new Point(89, 50);
            pictureBox1.Visible = false;
            button2.Visible = false;
            button5.Visible = false;
            button4.Visible = false;
            this.richTextBox1.ReadOnly = true;
            labelArbol.Text = "";
            muestra();

           
           

        }



        private void button3_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text = "";
            textBoxRut.Text = "";
            richTextBox1.Text = "";

            //label7Usuario.Text = "nombre";
        }

        private void button1_Click(object sender, EventArgs e)
        {

    
            button1.Location = new Point(9, 50);
            pictureBox1.Visible = true;
            button2.Visible = true;
            button5.Visible = true;
            button4.Visible = true;
 
            
        }

        private void button2_Click(object sender, EventArgs e) //id3
        {
            pictureBox1.Visible = false;
            button2.Visible = false;
            button5.Visible = false;
            button4.Visible = false;
            button1.Location = new Point(89, 50);
            labelArbol.Text = "ID3";
            NumeroArbol =  1;
            richTextBox1.Text = "";

            
        }

        private void button5_Click(object sender, EventArgs e)  // Diego lopez
        {
            pictureBox1.Visible = false;
            button2.Visible = false;
            button5.Visible = false;
            button4.Visible = false;
            button1.Location = new Point(89, 50);
            labelArbol.Text = "Lopez de mantaras";
            NumeroArbol = 2;
            richTextBox1.Text = "";

            

            

            
        }

        private void button4_Click(object sender, EventArgs e)  //Arbol del c4.5
        {
            pictureBox1.Visible = false;
            button2.Visible = false;
            button5.Visible = false;
            button4.Visible = false;
            button1.Location = new Point(89, 50);
            labelArbol.Text = "C4.5";
            NumeroArbol = 3;
            richTextBox1.Text = "";


        }

        private void Inicio_Load(object sender, EventArgs e)
        {
           //label3.Text = usuario;
        }

        public void muestra() {

            //label3.Text = usuario;
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
           // OpenFileDialog openFile1 = new OpenFileDialog();

            // Initialize the filter to look for text files.
           // openFile1.Filter = "Text Files|*.txt";

            // If the user selected a file, load its contents into the RichTextBox.
           // if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                

            if (NumeroArbol == 1 ) {

                richTextBox1.Text = "";
                richTextBox1.LoadFile("arbolID3.txt",
                RichTextBoxStreamType.PlainText);
            }
            if (NumeroArbol == 2) {

                richTextBox1.Text = "";
                richTextBox1.LoadFile("arbolLM.txt",
                RichTextBoxStreamType.PlainText);
            }
            if (NumeroArbol == 3) {

                richTextBox1.Text = "";
                richTextBox1.LoadFile("arbolC45.txt",
                RichTextBoxStreamType.PlainText);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
        //***************************************************************************************************
    }
}
