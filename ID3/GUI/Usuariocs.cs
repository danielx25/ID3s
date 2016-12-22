using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ID3.GUI
{
    public partial class Usuariocs : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        verUsuarios verUS = new verUsuarios();

        public Usuariocs()
        {
            InitializeComponent();
            this.Size = new Size(345, 414);
            btnIniciaSesion.BackColor = Color.DimGray;
            button1.Visible = false;
            btnListo.Visible = true;
            textBox2.PasswordChar = '*';
            textBox3.PasswordChar = '*';
            textBox6.PasswordChar = '*';
        }

        private void btnIniciaSesion_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel3.Visible = true;
            button1.Visible = false;
            btnListo.Visible = true;
            btnRegistro.BackColor = Color.DarkCyan;
            btnIniciaSesion.BackColor = Color.DimGray;
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            ;        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel3.Visible = false;
            panel4.Location = new Point(23, 137);
            btnIniciaSesion.BackColor = Color.DarkCyan;
            btnRegistro.BackColor = Color.DimGray;
            button1.Visible = true;
            button1.Location = new Point(105,347);
            btnListo.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            if (verUsuarios.Autenticar(textBox1.Text, textBox2.Text) == true)
            {
                Console.WriteLine("sesion iniciada");
                MessageBox.Show("Sesion iniciada corectamente", "Usuario",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                this.Close();
            }
            else
            {
                Console.WriteLine("usuario no registrado");
                MessageBox.Show("Usuario no resgistrado", "Error",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                textBox2.Text = "";
                textBox1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (verUsuarios.AutenticarRegistro(textBox4.Text, textBox5.Text) == true)
            {

                MessageBox.Show("Usuario ya registrado", "Mensaje",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
            else
            {

                if (textBox3.Text == textBox6.Text)
                {

                    verUS.registrarUsuario(textBox4.Text, textBox5.Text, textBox3.Text);
                    MessageBox.Show("Usuario registrado correctamente", "Mensaje",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    panel4.Visible = false;
                    panel3.Visible = true;
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    button1.Visible = false;
                    btnListo.Visible = true;
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    textBox3.Text = "";
                    textBox6.Text = "";
                }
               
            }


        }
    }
}
