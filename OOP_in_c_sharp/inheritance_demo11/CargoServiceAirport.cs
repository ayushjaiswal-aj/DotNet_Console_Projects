using System;
using System.Collections.Generic;

class CargoServiceAirport : Airport
{
    private int _noOfcargoUnitsperflight;

    public CargoServiceAirport(string _iataAirportCode, string _name, string _city, int _noOfFlights, int _noOfcargoUnitsperflight)
        : base (_iataAirportCode, _name, _city, _noOfFlights)
    {
        this._noOfcargoUnitsperflight = _noOfcargoUnitsperflight;
    }

    public override int calculate()
    {
        return _noOfcargoUnitsperflight * noOfFlights;
    }
}
