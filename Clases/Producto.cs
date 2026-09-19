using System;
using System.Collections.Generic;
using System.Text;

namespace Producto.Clases
{
    internal class Producto
    {
        private string _nombre;
        private decimal _precio;
        private int _cantidad;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public decimal Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public Producto(string nombre, decimal precio, int cantidad)
        {
            _nombre = nombre;
            _precio = precio;
            _cantidad = cantidad;
        }

        public decimal CalcularSubtotal()
        {
            return _precio * _cantidad;
        }
        public decimal CalcularTotalConIva()
        {
            
            decimal iva = CalcularSubtotal() * 0.19m; // Suponiendo un IVA del 19%
            return CalcularSubtotal() + iva;
        }

        public override string ToString()
        {
            return $"Nombre: {_nombre}, Precio: {_precio:C}, Cantidad: {_cantidad}, Subtotal: {CalcularSubtotal():C}, Total con IVA: {CalcularTotalConIva():C}";
        }
    }
}
