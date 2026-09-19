using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_inicial.Clases
{
    class Login
    {
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public Login()
        {
            Usuario = "Admin";
            Clave = "1234";
        }

        public bool ValidarAcceso(string usuario, string clave)
        {
            return Usuario == usuario && Clave == clave;
        }
    }
}
