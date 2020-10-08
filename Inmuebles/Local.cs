using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmuebles
{
    class Local
    {
        public double CalcularPrecioLocal(double precio, int años, int metroscuadrados, int ventanas)
        {
            double preciofinal=0;
            
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
