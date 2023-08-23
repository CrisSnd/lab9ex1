using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab9ex1
{
    internal class ContInvestitii : ContEconomii
    {
        private int dayOfExtraction;

        public ContInvestitii(int rata, int dayOfExtraction):base(rata)
        {
          
        }

        public override void ExtragereNumerar(decimal suma)
        {
            if (DateTime.UtcNow.Day < dayOfExtraction)
            {
                Console.WriteLine("Termenul de retragere nu a fost atins");
                return;
            }
            base.ExtragereNumerar (suma);

        }

    }
}
