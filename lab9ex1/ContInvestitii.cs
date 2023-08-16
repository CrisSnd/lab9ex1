using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9ex1
{
    internal class ContInvestitii : ContBancar
    {
        private int termenExtragereContInvestitii;


        public ContInvestitii  (int termenExtragereContInvestitii) 
            
        {
            this.termenExtragereContInvestitii= termenExtragereContInvestitii;
        }
    }
}
