using System;
public class TicketBooking
{
    public void MakePayment(double amount)
    {
        Console.WriteLine("You have selected the Cash payment mode");
        //fill your code here
        Console.WriteLine($"The Amount is Rs.{amount.ToString("0")}.");
    }

    public void MakePayment(string walletNumber, double amount)
    {
        Console.WriteLine("You have selected the Wallet payment mode");
        //fill your code here
        Console.WriteLine($"Wallet Number: {walletNumber}\n" +
            $"The Amount is Rs.{amount.ToString("0")}.");
    }

   public void MakePayment(string creditCard, string ccv, string name, double amount)
    {

        Console.WriteLine("You have selected the Credit Card payment mode");
        //fill your code here;
        Console.WriteLine($"CreditCard Number:{creditCard}\n" +
            $"Validity Date:{ccv}\n" +
            $"Card Holder Name: {name}\n" +
            $"The Amount is Rs.{amount.ToString("0")}.");

    }
}