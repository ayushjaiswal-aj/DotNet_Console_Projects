using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inheritance_demo2
{
    public class SeniorCitizenCustomer : Customer //Fill your code here
    {
        public double GenerateBillAmount(int amount)
        {
            //Fill your code here
            double billAmount = (double)amount - ((double)amount * 0.12);
            return billAmount;
        }
    }
}