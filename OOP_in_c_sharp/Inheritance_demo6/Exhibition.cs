using System;
class Exhibition : Event //Fill your code here
{
    //Fill your code here
    static private int _gst = 5;
    private int _noOfStalls;

    public Exhibition ()
    {

    }
    public Exhibition(string name, string type, double costPerDay, int noOfDays, int noOfStalls)
        : base(name, type, costPerDay, noOfDays)
    {
        _noOfStalls = noOfStalls;
    }

   public double totalCost() {
        //Fill your code here
        double tc = base._costPerDay * base._noOfDays;
        tc = tc + (tc * ((double)_gst/100));
      return tc;
   }
   
   public override string ToString() {
      //Fill your code here
      return $"Name:{base._name}\n" +
            $"Type:{base._type}\n" +
            $"Number of stalls:{_noOfStalls}\n" +
            $"Total amount: {totalCost().ToString("0.00")}";
   }
}