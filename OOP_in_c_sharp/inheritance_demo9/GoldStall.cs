using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GoldStall : Stall
{

    //Fill Your Code Here
    private double _discount;

    public GoldStall(string _name, string _detail, string _owner, double cost, double _discount)
        : base (_name, _detail, _owner, cost)
    {
        this._discount = _discount;   
    }

    public override double calculateRent(int days)
    {
        return ((base._costPerDay * days) - ((base._costPerDay * days) * (_discount/100)));
    }

    public override string ToString()
    {

        //Fill Your Code Here
        return ($"Name : {base._name}\n" +
            $"Detail : {base._detail}\n" +
            $"Owner : {base._owner}" +
            $"Cost Per Day : {base._costPerDay}\n" +
            $"Your Total Cost ");
    }

}

