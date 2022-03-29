using System;
class Event
{
    protected string _name;
    protected string _type;
    protected double _costPerDay;
    protected int _noOfDays;


    //Fill your code here
    public Event()
    {

    }
    public Event (string name, string type, double costPerDay, int numberOfDays)
    {
        _name = name;
        _type = type;
        _costPerDay = costPerDay;
        _noOfDays = numberOfDays;
    }
}