using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inheritance_demo2
{
    public class PrivilegeCustomer : Customer //Fill your code here
    {
        public double GenerateBillAmount(int amount)
        {
            //Fill your code here
            double billAmount = (double)amount - ((double)amount * 0.30);
            return billAmount;
        }
    }

}
