using System;
class Exhibition : Event
{
    //Fill your code here
    private int _stallCount;

    public Exhibition(string _name, string _detail, string _organizer, int _stallCount)
        : base(_name, _detail, _organizer)
    {
        this._stallCount = _stallCount;
    }

    public override void TotalCredit()
    {
        //Fill your code here
        base.TotalCredit();
        Console.WriteLine($"Total Credit Gained is {_stallCount * 50}");
    }
    public override string ToString()
    {
        //Fill your code here
        return ($"Event Name : {_name}\n" +
            $"Event Detail: {_detail}\n" +
            $"Event Organizer: {_organizer}\n" +
            $"Count: {_stallCount}");
    }

}

