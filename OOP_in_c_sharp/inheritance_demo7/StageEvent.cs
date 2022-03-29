using System;
class StageEvent : Event
{
    //Fill your code here
    private int _totalShow;
    private int _seatsPerShow;

    public StageEvent(string _name, string _detail, string _organizer, int _totalShow, int _seatsPerShow)
        : base(_name, _detail, _organizer)
    {
        this._totalShow = _totalShow;
        this._seatsPerShow = _seatsPerShow;
    }

    public override void TotalCredit()
    {
        //Fill your code here
        base.TotalCredit();
        Console.WriteLine($"Total Creadit Gained is {_totalShow * _seatsPerShow * 100}");
    }
    public override string ToString()
    {
        //Fill your code here
        return ($"Event Name : {_name}\n" +
            $"Event Detail : {_detail}\n" +
            $"Event Organizer : {_organizer}\n" +
            $"Total Events : {_totalShow}\n" +
            $"Total Seats : {_seatsPerShow}");
    }
}

