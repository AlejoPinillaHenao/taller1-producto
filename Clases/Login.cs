using System;
using System.Collections.Generic;
using System.Text;

namespace Producto.Clases
{
    class Login
    {
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public Login()
        {
            Usuario = "Admin";
            Clave = "123456";
        }

        public bool ValidarAcceso(string usuario, string clave)
        {
            return Usuario == usuario && Clave == clave;
        }
    }
}
