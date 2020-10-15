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
        private double preciobase;

        public double Preciobase { get => preciobase; set => preciobase = value; }
        protected string Direccion { get => direccion; set => direccion = value; }
        protected int Metroscuadrados { get => metroscuadrados; set => metroscuadrados = value; }
        protected int Antiguedad { get => antiguedad; set => antiguedad = value; }
        protected bool Nuevousado { get => nuevousado; set => nuevousado = value; }

        public double Calcular(double precio, int años)
        {
            double preciofinal = 0;

            if (años < 15)
            {
                preciofinal -= precio * 0.01;
            }
            else
            {
                if (años >= 15)
                {
                    preciofinal -= precio * 0.02;
                }
            }

            return preciofinal;

        }
    }
}
