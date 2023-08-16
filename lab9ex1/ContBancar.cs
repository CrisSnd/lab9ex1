using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9ex1
{
    class ContBancar
    {
        private string numeCont;
        private int soldCurent;
        private int depunereCont;
        private int extragereCont;
       
      


        public void AfisareTipCont()
        {
            Console.WriteLine("1. Cont Economii");
            Console.WriteLine("2. Cont Curent");
            Console.WriteLine("3. Cont Investitii");
        }

        public void AlegereTipCont()
        {
            int numarTipCont;
            Console.WriteLine("\n Introduceti cifra corespunzatoare tipului de cont:");
            numarTipCont = int.Parse(Console.ReadLine());

            ContEconomii contE = new ContEconomii();

            if (numarTipCont == 1)
            {
                Console.WriteLine("Ati ales Contul de Economii");
                
                contE.GetDepunereContEconomii();

               double cont= contE.sold;
            }


            else if (numarTipCont == 2)
            {
                Console.WriteLine("Ati ales Contul Curent");
            }

            else if (numarTipCont == 3)
            {
                Console.WriteLine(" Ati ales Contul de Investitii");
            }

            else
            {
                Console.WriteLine("Introduceti corect cifra corespunzatoare tipului de cont!");
            }
        }
        



        public int GetSumaExtrasa
        {
            get; set;

        }


        public  int GetSoldCont
        {
            get; set;

        }

    }

}
