using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9ex1
{
    class ContBancar
    {

    protected decimal sold = 0.0m;


        public virtual bool DepunereNumerar(decimal suma)
        {
            if (suma < 0)
            {
                Console.WriteLine("Suma invalida");
                return false;
            }

            sold += suma;
            return true;
        }

        public virtual void ExtragereNumerar(decimal suma)
        { 
            if (suma < 0)
            {
                Console.WriteLine("Suma invalida");
                return;
            }

            if (suma > sold)
            {
             Console.WriteLine("Suma pentru extragere este prea mare");
                return;
            }

        }


    }

}
