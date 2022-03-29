using System;

abstract class Airport
{
    private string _iataAirportCode;
    private string _name;
    private string _city;
	private int _noOfFlights;
    
    public string iataAirportCode
    {
        get { return _iataAirportCode; }
        set { _iataAirportCode = value; }
    }

    public string name
    {
        get { return _name; }  
        set { _name = value; }
    }

    public string city
    {
        get { return _city; }
        set { _city = value; }
    }

    public int noOfFlights
    {
        get { return _noOfFlights; }
        set { _noOfFlights = value; }
    }

    public Airport(string _iataAirportCode, string _name, string _city, int _noOfFlights)
    {
        this._iataAirportCode = _iataAirportCode;
        this._name = _name;
        this._city = _city;
        this._noOfFlights = _noOfFlights;
    }

    public abstract int calculate();
}
