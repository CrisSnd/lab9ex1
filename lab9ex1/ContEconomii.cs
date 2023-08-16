using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9ex1
{
    internal class ContEconomii 
    {
        private double rataDobanda=4;
        private int depunereContEconomii;
        private double soldContEconomii;
        public double sold;
       

        public void GetDepunereContEconomii()
        {
            Console.WriteLine("Introduceti suma pentru depunere:");
            depunereContEconomii = int.Parse(Console.ReadLine());
        }


         public void SoldContEconomii()
        {
          
           double calcDobanda = (depunereContEconomii * rataDobanda)/100;
           double sold=depunereContEconomii+calcDobanda;
              
           Console.WriteLine($"Soldul d-voastra este {sold} RON.");



           Console.WriteLine("Introduceti 'DA'pentru repetare depunere.");
            string repetareDepunere;
            repetareDepunere = Console.ReadLine();

            if (repetareDepunere == "DA")
            {
                ContBancar contB=new ContBancar();
                contB.AlegereTipCont();
            } 
                

        }

    }
              
 }
 

