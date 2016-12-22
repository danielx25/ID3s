using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID3
{
    class loginUsuarios
    {
        public loginUsuarios(string nombre, string apellido, string password)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Password = password;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Password { get; set; }
    }

}
