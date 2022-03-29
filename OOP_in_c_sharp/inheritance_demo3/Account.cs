using System;
class Account
{
    protected string _holderName;
    protected long _accountNumber;
    protected string _IFSCCode;
    protected long _contactNumber;
    //Fill your code here
    
    public string HolderName { get { return _holderName; } set { _holderName = value; } }
    public long AccountNumber { get { return _accountNumber; } set { _accountNumber = value;} }
    public string IFSCCode { get { return _IFSCCode; } set { _IFSCCode = value; } }
    public long ContactNumber { get { return _contactNumber; } set { _contactNumber = value;} }

    public Account()
    {

    }

    public Account (string holderName, long accountNumber, string IFSCCOde, long contactNumber)
    {
        _holderName = holderName;
        _accountNumber = accountNumber;
        _IFSCCode = IFSCCOde;
        _contactNumber = contactNumber;
    }

    public virtual void Display()
    {
        //Fill your code here
        Console.WriteLine("Your Contact Details");
        Console.WriteLine($"HolderName : {HolderName}\n" +
            $"Account Number : {AccountNumber}\n" +
            $"IFSCCode : {IFSCCode}\n" +
            $"ContactNumber : {ContactNumber}");
    }
}
