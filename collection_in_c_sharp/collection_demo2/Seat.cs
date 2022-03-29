using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Seat
{
    char _section;
    int _number;
    bool _booked;

    public char Section
    {
        get { return this._section; }
        set { this._section = value; }
    }

    public int Number
    {
        get { return this._number; }
        set { this._number = value; }
    }

    public bool Booked
    {
        get { return this._booked; }
        set { this._booked = value; }
    }

    public Seat() { }

    public Seat(char _section, int _number, bool _booked)
    {
        this._section = _section;
        this._number = _number;
        this._booked = _booked;
    }
}