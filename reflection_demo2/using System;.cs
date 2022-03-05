using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Hall
{
    private string _name;
    private string _contactNumber;
    private double _costPerDay;
    private string _ownerName;
    private DateTime _bookingDate;

    //fill code here

    Hall ()
    {
        _name = "";
        _contactNumber = "";
        _costPerDay = 0.0;
        _ownerName = "";
        _bookingDate = DateTime.Now;
    }

    public string Name 
    {
        get {return _name;}
        set {_name = value;}
    }

    public string ContactNumber
    {
        get {return _contactNumber;}
        set {_contactNumber = value;}
    }

    public double CostPerDay
    {
        get {return _costPerDay;}
        set {_costPerDay = value;}
    }

    public string OwnerName
    {
        get {return _ownerName;}
        set {_ownerName = value;}
    }

    public DateTime BookingDate
    {
        get {return _bookingDate;}
        set {_bookingDate = value;}
    }
}