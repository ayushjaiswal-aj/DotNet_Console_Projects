using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter User Details(HolderName,Account Number,IFSC code,Contact Number)");
        string details = Console.ReadLine();
        string[] accountInfo = details.Split(",");
        Console.WriteLine("Enter Account Type");
        string accountType = Console.ReadLine();
        if("saving" == accountType)
        {
            SavingAccount sa = new SavingAccount();
            sa.HolderName = accountInfo[0];
            sa.AccountNumber = Convert.ToInt64(accountInfo[1]);
            sa.IFSCCode = accountInfo[2];
            sa.ContactNumber = Convert.ToInt64(accountInfo[3]);
            Console.WriteLine("Enter Interest Rate");
            sa.InterestRate = Convert.ToDouble(Console.ReadLine());
            sa.Display();
        }
        else if("current" == accountType)
        {
            CurrentAccount ca = new CurrentAccount();
            ca.HolderName = accountInfo[0];
            ca.AccountNumber = Convert.ToInt64(accountInfo[1]);
            ca.IFSCCode= accountInfo[2];
            ca.ContactNumber = Convert.ToInt64(accountInfo[3]);
            Console.WriteLine("Enter organization Name");
            ca.OrganizationName = Console.ReadLine();
            Console.WriteLine("Enter TIN number");
            ca.TIN = Convert.ToInt64(Console.ReadLine());
            ca.Display();

        }
        else
        {
            Console.WriteLine("Enter valid Account Type");
        }
    }
}

