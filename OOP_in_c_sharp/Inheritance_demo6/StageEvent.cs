using System;
class StageEvent : Event//Fill your code here
{
    //Fill your code here
    static private int _gst = 15;
    private int _noOfSeats;

    public StageEvent()
    {

    }
    public StageEvent(string name, string type, double costPerDay, int noOfDays, int noOfSeats)
        : base (name, type, costPerDay, noOfDays)
    {
        _noOfSeats = noOfSeats;
    }

   public double totalCost() {
        //Fill your code here
        double tc = base._costPerDay * base._noOfDays;
        tc = tc + (tc * ((double)_gst / 100));
        return tc;
    }
   
   public override string ToString() {
        //Fill your code here
        return $"Name:{base._name}\n" +
              $"Type:{base._type}\n" +
              $"Number of seats:{_noOfSeats}\n" +
              $"Total amount: {totalCost().ToString("0.00")}";
    }
}