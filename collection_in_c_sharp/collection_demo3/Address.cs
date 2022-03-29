using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Address
{
    private string _addr1;
    private string _addr2;
    private string _city;
    private string _state;
    private int _pincode;
    public Address(string addr1, string addr2, string city, string state, int pincode)
    {
        this._addr1 = addr1;
        this._addr2 = addr2;
        this._city = city;
        this._state = state;
        this._pincode = pincode;
    }
    public string Addr1
    {
        get { return this._addr1; }
        set { this._addr1 = value; }
    }
    public string Addr2
    {
        get { return this._addr2; }
        set { this._addr2 = value; }
    }
    public string City
    {
        get { return this._city; }
        set { this._city = value; }
    }
    public string State
    {
        get { return this._state; }
        set { this._state = value; }
     }
     public int Pincode
     {
        get { return this._pincode; }
        set { this._pincode = value; }
     }
     public override string ToString()
        {
            return (String.Format("{0,-30} {1,-30} {2,-15} {3,-15} {4,-10}", this._addr1, this._addr2, this._city, this._state, this._pincode));
        }
}