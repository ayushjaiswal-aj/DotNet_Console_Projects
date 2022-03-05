using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StageEvent : Event
{
    private int _noOfShows;
    private int _noOfSeats;

    public StageEvent(string _name, string _type, int _noOfSeats, int _noOfShows) : base(_name, _type)
    {
        this._noOfSeats = _noOfSeats;
        this._noOfShows = _noOfShows;
    }

    public int NoOfShows
    {
        get{
            return this._noOfShows;
        }
        set{
            this._noOfShows = value;
        }
    }

    public int NoOfSeats
    {
        get{
            return this._noOfSeats;
        }
        set{
            this._noOfSeats = value;
        }
    }
}