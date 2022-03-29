using System;

class CommercialServiceAirport : Airport
{
    private int _noOfpassengersperflight;

    public CommercialServiceAirport(string _iataAirportCode, string _name, string _city, int _noOfFlights, int _noOfpassengersperflight)
        : base(_iataAirportCode, _name, _city, _noOfFlights)
    {
        this._noOfpassengersperflight = _noOfpassengersperflight;
    }
    public override int calculate()
    {
        return _noOfpassengersperflight * noOfFlights;
    }
}
