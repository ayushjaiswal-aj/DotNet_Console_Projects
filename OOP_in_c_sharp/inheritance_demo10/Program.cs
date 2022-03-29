using System;
public class Program
{
    public static void Main(string[] args)
    {
        TicketBooking tb = new TicketBooking();
        Console.WriteLine("Enter the mode of Payment:\n1.Cash Payment\n2.Wallet Payment\n3.Credit Card");

        int modee = Convert.ToInt32(Console.ReadLine());
        double amount;
 
        switch (modee)
        {
            case 1:
                Console.WriteLine("Enter the Amount of Payment:");
                amount = Convert.ToDouble(Console.ReadLine());
                tb.MakePayment(amount);
                //fill your code here
                break;
            case 2:
                Console.WriteLine("Enter the Wallet Number:");
                string walletNumber = Console.ReadLine();
                Console.WriteLine("Enter the Amount of Payment:");
                amount = Convert.ToDouble(Console.ReadLine());
                tb.MakePayment(walletNumber, amount);
                //fill your code here
                break;
            case 3:
                Console.WriteLine("Enter the Credit Card Number:");
                string cardNumber = Console.ReadLine();
                Console.WriteLine("Enter the Validity Date(dd/MM/yyyy):");
                string validityDate = Console.ReadLine();
                Console.WriteLine("Enter the Card Holder Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Amount of Payment:");
                amount = Convert.ToDouble(Console.ReadLine());
                tb.MakePayment(cardNumber, validityDate, name, amount);
                //fill your code here
                break;

            case 4:
                Console.WriteLine("Please select the correct mode of payment...");
                break;
        }
        Console.ReadLine();
    }
}