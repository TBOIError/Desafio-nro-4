using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmuebles
{
    class Piso : Inmueble
    {
        public double CalcularPrecioPiso(double precio, int años, int nropiso)
        {
            double preciofinal = 0 ;

            if (años <= 15)
            {
                preciofinal -= precio * 0.01;
            }
            else
            {
                if (años > 15)
                {
                    preciofinal -= precio * 0.02;
                }
            }

            if (nropiso >= 3)
            {
                preciofinal += precio * 0.03;
            }

            preciofinal += precio;

            return preciofinal;
        }
    }
}
