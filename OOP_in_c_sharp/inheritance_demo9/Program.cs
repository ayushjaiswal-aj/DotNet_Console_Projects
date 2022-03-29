using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter stall name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter stall detail");
        string detail = Console.ReadLine();
        Console.WriteLine("Enter stall owner name");
        string owner = Console.ReadLine();
        Console.WriteLine("Enter cost per day");
        double costPerDay = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("1.Stall 2.GoldStall 3.PlatinumStall");
        int ch = Convert.ToInt32(Console.ReadLine());
        //Fill Your Code Here
        int days;
        double discount;
        string coupon;
        switch (ch)
        {
            case 1:
                Stall stall = new Stall(name, detail, owner, costPerDay);
                Console.WriteLine("Enter Total Number of Days");
                days = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(stall.ToString() + stall.calculateRent(days).ToString("0"));
                break;

            case 2:
                Console.WriteLine("Enter Total Number of Days");
                days = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter discount percentage");
                discount = Convert.ToDouble(Console.ReadLine());
                GoldStall goldStall = new GoldStall(name, detail, owner, costPerDay, discount);
                Console.WriteLine(goldStall.ToString() + goldStall.calculateRent(days).ToString("0"));
                break;

            case 3:
                Console.WriteLine("Enter Total Number of Days");
                days = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter discount percentage");
                discount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Coupon Yes/No");
                coupon = Console.ReadLine();
                PlatinumStall platinumStall = new PlatinumStall(name, detail, owner, costPerDay, discount, "yes" == coupon.ToLower());
                Console.WriteLine(platinumStall.ToString() + platinumStall.calculateRent(days).ToString("0"));
                break;

            default:
                break;
        }
    }
}
