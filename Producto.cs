﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1._2_2C
{
    public abstract class Producto : IPrecio
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Producto()
        {
            Codigo = 1;
            Nombre = string.Empty;
            Precio = 0;
        }

        public Producto(int codigo, string nombre, double precio)
        {
            Codigo = codigo; 
            Nombre = nombre;
            Precio = precio;
        }

        public abstract double CalcularPrecio();

    }
}
