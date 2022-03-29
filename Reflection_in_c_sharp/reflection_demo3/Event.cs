using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Event
{
    private string _name;
    private string _type;

    public Event(string _name, string _type)
    {
        this._name = _name;
        this._type = _type;
    }
    public string Name
    {
        get{
            return this._name;
        }
        set{
            this._name = value;
        }
    }
    public string Type
    {
        get{
            return this._type;
        }
        set{
            this._type = value;
        }
    }

}