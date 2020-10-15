using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmuebles
{
    class Local : Inmueble
    {

        private int ventanas;

        public int Ventanas { get => ventanas; set => ventanas = value; }

        public double Calcular(double precio, int años, int metroscuadrados, int ventanas)
        {
            double preciofinal = base.Calcular(precio, años);

            if (metroscuadrados > 50)
            {
                preciofinal += precio * 0.01;
            }

            if (ventanas <= 1)
            {
                preciofinal -= precio * 0.02;
            }
            else
            {
                if (ventanas > 4)
                {
                    preciofinal += precio * 0.02;
                }
            }

            preciofinal += precio;

            return preciofinal;
        }
    }
}
