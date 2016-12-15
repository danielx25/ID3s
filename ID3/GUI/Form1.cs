using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ID3.GUI;

namespace ID3
{
    public partial class Form1 : Form
    {
        //Para mover los panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        
        public Form1()
        {
            InitializeComponent();
            AddFormInPanel(new Inicio());
        }

        
        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            label3.Text = "INICIO";
            AddFormInPanel(new Inicio());
           

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            label3.Text = "USUARIO";
            Usuario u = new Usuario();
            u.Show();
            //this.panel7.Controls.Clear();
        }

        private void btnHerramienta_Click(object sender, EventArgs e)
        {
            label3.Text = "HERRAMIENTAS";
            AddFormInPanel3(new herramientas());
            Console.WriteLine("\nFunciona la consola junto con la GUI\n");

        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            label3.Text = "AYUDA";
            /*Ram r = new Ram();
            r.Show();*/
        }


        //Poner panel en el form principal 
        private void AddFormInPanel(object formHijo)
        {
            if (this.panel7.Controls.Count > 0)
                this.panel7.Controls.RemoveAt(0);
            Inicio fh = new Inicio();
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel7.Controls.Add(fh);
            this.panel7.Tag = fh;
            fh.Show();

        }

        private void AddFormInPanel2(object formHijo)
        {
            if (this.panel7.Controls.Count > 0)
                this.panel7.Controls.RemoveAt(0);
            Usuario fh = new Usuario();
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel7.Controls.Add(fh);
            this.panel7.Tag = fh;
            fh.Show();

        }

        private void AddFormInPanel3(object formHijo)
        {
            if (this.panel7.Controls.Count > 0)
                this.panel7.Controls.RemoveAt(0);
            herramientas fh = new herramientas();
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel7.Controls.Add(fh);
            this.panel7.Tag = fh;
            fh.Show();

        }


    }
}
