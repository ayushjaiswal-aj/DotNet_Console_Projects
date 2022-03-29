using System;

class Program
{
    static void Main(string[] args)
    {
        //fill code here
        string info;
        string input;
        do
        {
            Console.WriteLine("Enter the transaction detail");
            info = Console.ReadLine();
            string[] details = info.Split(",");
            if("VISA card" == details[2])
            {
                VISACard vc = new VISACard();
                Console.WriteLine($"Total reward points earned in this transaction is {vc.ComputeRewardPoints(details[0], Convert.ToDouble(details[1]))}");

            }
            else if("HPVISA card" == details[2])
            {
                HPVISACard hvc = new HPVISACard();
                Console.WriteLine($"Total reward points earned in this transaction is {hvc.ComputeRewardPoints(details[0], Convert.ToDouble(details[1]))}");

            }
            else
            {
                Console.WriteLine("Invalid data");
            }
            Console.WriteLine("Do you want to continue?(Yes/No)");
            input = Console.ReadLine();
        }while ("Yes" == input);
    }
}