using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1._2_2C
{
    public class Pack : Producto
    {
        public int Cantidad { get; set; }
        public Pack() : base()
        { 
            Cantidad = 0;
        }

        public Pack(int cantidad) : base()
        {
            Cantidad = cantidad;
        }
        public override double CalcularPrecio()
        {
            double precioTotal = Precio * Cantidad;
            return precioTotal;
        }

        public override string ToString()
        {
            return $"Precio: {Precio}";
        }
    }
}
