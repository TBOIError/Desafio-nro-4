using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmuebles
{
    class Piso : Inmueble
    {
        private int nropiso;

        public int Nropiso { get => nropiso; set => nropiso = value; }

        public double Calcular(double precio, int años, int nropiso, int metroscuadrados)
        {
            double preciofinal = base.Calcular(precio, años);

            if (nropiso >= 3)
            {
                preciofinal += precio * 0.03;
            }

            preciofinal += precio;

            return preciofinal;
        }
    }
}
