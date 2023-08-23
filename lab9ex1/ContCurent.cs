using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9ex1
{
    internal class ContCurent:ContBancar
    {
        public override void ExtragereNumerar(decimal suma)
        {
            if (suma < 0)
            {
                Console.WriteLine("Suma invalida.");
                return;
            }

            if (suma > sold+5000)
            {
                Console.WriteLine("Suma pentru extragere este prea mare");
                return;
            }
            sold -= suma;

        }

    }
}
