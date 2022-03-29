using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace inheritance_demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1)Privilege Customer\n2)SeniorCitizen Customer\nEnter Customer Type");
            int ch = int.Parse(Console.ReadLine());
            int purchasedAmount;
            double billAmount;
            PrivilegeCustomer pc = new PrivilegeCustomer();
            SeniorCitizenCustomer scc = new SeniorCitizenCustomer();
            if (ch > 0 && ch < 3)
            {
                if (ch == 1)
                {
                    //Fill your code here
                    Console.WriteLine("Enter The Name");
                    pc.Name = Console.ReadLine();
                    Console.WriteLine("Enter The Age");
                    pc.Age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter The Address");
                    pc.Address = Console.ReadLine();
                    Console.WriteLine("Enter The Mobile Number");
                    pc.MobileNumber = Console.ReadLine();
                    Console.WriteLine("Enter The Purchased Amount");
                    purchasedAmount = Convert.ToInt32(Console.ReadLine());
                    pc.DisplayCustomer();
                    billAmount = pc.GenerateBillAmount(purchasedAmount);
                    Console.WriteLine($"Your bill amount is Rs {purchasedAmount.ToString("0.0")} Your bill amount is discount under privilege customer\nYou have to pay Rs {billAmount.ToString("0.00")}");

                }
                else
                {
                    //Fill your code here
                    Console.WriteLine("Enter The Name");
                    scc.Name = Console.ReadLine();
                    Console.WriteLine("Enter The Age");
                    scc.Age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter The Address");
                    scc.Address = Console.ReadLine();
                    Console.WriteLine("Enter The Mobile Number");
                    scc.MobileNumber = Console.ReadLine();
                    Console.WriteLine("Enter The Purchased Amount");
                    purchasedAmount = Convert.ToInt32(Console.ReadLine());
                    scc.DisplayCustomer();
                    billAmount = scc.GenerateBillAmount(purchasedAmount);
                    Console.WriteLine("Your bill amount is Rs {0} Your bill amount is discount under senior citizen customer\nYou have to pay Rs {1}", purchasedAmount.ToString("0.0"), billAmount.ToString("0.00"));
                }
            }
            else
            {
                Console.WriteLine("Invalid Customer Type");
            }
        }
    }

}