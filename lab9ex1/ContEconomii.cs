using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9ex1
{
    internal class ContEconomii : ContBancar
    {
        private int rataDobanzii;


        public ContEconomii(int rataDobanzii)
        { 
            this.rataDobanzii = rataDobanzii;
        }

        public override void ExtragereNumerar(decimal suma)
        {
            if (suma<0) 
            {
                Console.WriteLine("Suma Invalida");
                return;
            }

            if (suma > sold)
            {
                Console.WriteLine("Suma pentru extragere prea mare");
                return;
            }
             sold-=suma;
        }

        public override bool DepunereNumerar(decimal suma) 
        {
            if (base.DepunereNumerar(suma))
            {
                sold = sold * (100.0m + rataDobanzii) / 100.0m;
                return true;
            }
            return false;
        }
         
    }    
              
 }
 

