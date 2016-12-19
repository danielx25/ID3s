using ID3.GUI;
using ID3.ID3s;
using ID3.ID3s.ID3s;
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

        public Inicio()
        {
            InitializeComponent();
            button1.Location = new Point(89, 50);
            pictureBox1.Visible = false;
            button2.Visible = false;
            button5.Visible = false;
            button4.Visible = false;
            muestra();

           
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text = "";
            //textBoxID.Text = "";
            textBoxRut.Text = "";

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

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            button2.Visible = false;
            button5.Visible = false;
            button4.Visible = false;
            button1.Location = new Point(89, 50);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            button2.Visible = false;
            button5.Visible = false;
            button4.Visible = false;
            button1.Location = new Point(89, 50);
        }

        private void button4_Click(object sender, EventArgs e)  //Arbol del c4.5
        {
            pictureBox1.Visible = false;
            button2.Visible = false;
            button5.Visible = false;
            button4.Visible = false;
            button1.Location = new Point(89, 50);

           
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
           //label3.Text = usuario;
        }

        public void muestra() {

            label3.Text = usuario;
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
