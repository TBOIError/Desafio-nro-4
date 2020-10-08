using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmuebles
{
    abstract class Inmueble
    {
        private String direccion;
        private int antiguedad;
        private bool nuevousado;
        private int metroscuadrados;
        private int ventanas;
        private int nropiso;
        private double preciobase;

        public double Preciobase { get => preciobase; set => preciobase = value; }
        protected string Direccion { get => direccion; set => direccion = value; }
        protected int Metroscuadrados { get => metroscuadrados; set => metroscuadrados = value; }
        protected int Ventanas { get => ventanas; set => ventanas = value; }
        protected int Nropiso { get => nropiso; set => nropiso = value; }
        protected int Antiguedad { get => antiguedad; set => antiguedad = value; }
        protected bool Nuevousado { get => nuevousado; set => nuevousado = value; }
    }
}
