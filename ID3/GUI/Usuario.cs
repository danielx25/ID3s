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

namespace ID3
{
    public partial class Usuario : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        Inicio inc = new Inicio();
        
        public Usuario()
        {
            InitializeComponent();
            this.Size = new Size(345,414);
            btnIniciaSesion.BackColor = Color.DimGray;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel3.Visible = true;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel3.Visible = false;
            panel4.Location = new Point(23, 137);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inicio inc = new Inicio();
            inc.usuario = "hola";
            
            
        }

        private void btnIniciaSesion_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel3.Visible = true;
            btnRegistro.BackColor = Color.DarkCyan;
            btnIniciaSesion.BackColor = Color.DimGray;      
         }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel3.Visible = false;
            panel4.Location = new Point(23, 137);
            btnIniciaSesion.BackColor = Color.DarkCyan;
            btnRegistro.BackColor = Color.DimGray;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
