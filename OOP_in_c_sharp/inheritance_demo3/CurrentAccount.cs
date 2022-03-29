using System;
class CurrentAccount : Account
{
    //Fill your code here
    private string _organizationName;
    private long _TIN;

    public string OrganizationName { get { return _organizationName; } set { _organizationName = value; } }
    public long TIN { get { return _TIN; } set { _TIN = value; } }

    public CurrentAccount() : base()
    {

    }

    public CurrentAccount(string holderName, long accountNumber, string ifscCode, long contactNumber, string organizationName, long TIN)
        : base(holderName, accountNumber, ifscCode, contactNumber)
    {
        OrganizationName = organizationName;
        this.TIN = TIN;
    }

    public override void Display()
    {
        //Fill your code here
        base.Display();
        Console.WriteLine($"Organization Name : {OrganizationName}\n" +
            $"TIN : {TIN}");
    }
}
