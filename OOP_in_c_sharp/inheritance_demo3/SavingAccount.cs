using System;
class SavingAccount : Account
{
    //Fill your code here
    private double _interestRate;

    public double InterestRate { get { return _interestRate; } set { _interestRate = value; } }

    public SavingAccount()
    {

    }

    public SavingAccount(string holderName, long accountNumber, string IFSCCode, long contactNumber, double interestRate)
        : base (holderName, accountNumber, IFSCCode, contactNumber)
    {
        InterestRate = interestRate;
    }

    public override void Display()
    {
        //Fill your code here
        base.Display();
        Console.WriteLine($"Interest Rate : {InterestRate.ToString("0")}");
    }
    
}

