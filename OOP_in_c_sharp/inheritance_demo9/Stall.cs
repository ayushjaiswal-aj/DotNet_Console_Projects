using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Stall
{
	public string _name;
	public string _detail;
	public double _costPerDay;
	public string _owner;
	public Stall(string _name, string _detail, string _owner, double cost)
	{
		this._name = _name;
		this._detail = _detail;
		this._owner = _owner;
		this._costPerDay = cost;
	}
	public virtual double calculateRent(int days)
	{
		//Fill Your Code Here
		return days * _costPerDay;
	}
	
	public override string ToString()
	{
		//Fill Your Code Here

		return ($"Name : {_name}\n" +
			$"Detail : {_detail}\n" +
            $"Owner : {_owner}" +
			$"Cost Per Day : {_costPerDay}\n" +
			$"Your Total Cost ");

	}
}

