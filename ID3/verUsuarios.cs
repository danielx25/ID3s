using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID3
{
    class verUsuarios
    {

        public static List<loginUsuarios> GetUsuario()
        {
            List<loginUsuarios> lista = new List<loginUsuarios>();

            using (StreamReader sr = new StreamReader("usuario.txt"))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] infousu = line.Split(';');
                    loginUsuarios usu = new loginUsuarios(infousu[0], infousu[1], infousu[2]);
                    lista.Add(usu);
                }
            }

            return lista;
        }

        //******************************************************************************************************************
        public static bool Autenticar(string nombre, string password)
        {
            bool result = false;
            List<loginUsuarios> lista = GetUsuario();

            foreach (loginUsuarios usu in lista)
            {
                if (usu.Nombre == nombre && usu.Password == password)
                {
                    result = true;
                    break;
                }

            }

            return result;
        }

        public static bool AutenticarRegistro(string nombre, string apellido)
        {
            bool result = false;
            List<loginUsuarios> lista = GetUsuario();

            foreach (loginUsuarios usu in lista)
            {
                if (usu.Nombre == nombre && usu.Apellido == apellido)
                {
                    result = true;
                    break;
                }

            }

            return result;
        }
        //****************************************************************************************************************

        public void registrarUsuario(string nombre, string apellido, string contraseña)
        {

            const string fic = "usuario.txt";
            string texto = "Érase una vez una vieja con un moño...";
            StreamWriter sw = new StreamWriter("usuario.txt", true);

            sw.WriteLine(nombre + ";" + apellido + ";" + contraseña + ";");
            sw.Close();

        }
    }
}
