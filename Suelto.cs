using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1._2_2C
{
    public  class Suelto : Producto
    {
        public double Medida { get; set; }
        public Suelto() :base()
        {
        Medida = 0;
        }

        public Suelto(double medida) : base()
        {
            Medida = medida;
        }

        public override double CalcularPrecio()
        {
            double precioTotal = Medida * Precio;
            return precioTotal;
        }

        public override string ToString()
        {
            return $"Precio: {Precio}";
        }
    }
}
