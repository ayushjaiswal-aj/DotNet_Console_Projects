using System;

class Stall
{
    public void ComputeCost(string _stallType, int _squareFeet)
    {
        //fill code here
        Console.WriteLine($"{_stallType} costs Rs.{_squareFeet * 100}");
    }

    public void ComputeCost(string _stallType, int _squareFeet, int _numberOfTV)
    {
        //fill code here
        Console.WriteLine($"{_stallType} costs Rs.{(_squareFeet * 150) + (_numberOfTV * 100) }");

    }

    public void ComputeCost(string _stallType, int _squareFeet, bool _projectorAvailability)
    {
        //fill code here
        Console.WriteLine($"{_stallType} costs Rs.{(_squareFeet * 200) + (_projectorAvailability ? 1000 : 0)}");

    }
}
