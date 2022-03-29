using System;
using System.Collections.Generic;

class Hall
{
	private string _name;
	private long _contactNumber;
	private double _costPerDay;
	private string _ownerName;
	
	public string Name
	{
		get
		{
			return _name;
		}
		set
		{
			_name = value;
		}
	}
	public long ContactNumber
	{
		get
		{
			return _contactNumber;
		}
		set
		{
			_contactNumber = value;
		}
	}
	public double CostPerDay
	{
		get
		{
			return _costPerDay;
		}
		set
		{
			_costPerDay = value;
		}
	}
	public string OwnerName
	{
		get
		{
			return _ownerName;
		}
		set
		{
			_ownerName = value;
		}
	}
	
	public Hall() { }
	public Hall(string _name, long _contactNumber, double _costPerDay, string _ownerName) {
		this._name = _name;
		this._contactNumber = _contactNumber;
		this._costPerDay = _costPerDay;
		this._ownerName = _ownerName;
	}
	
    public override string ToString()
    {
        return String.Format("{0,-30}{1,-15}{2,-15}{3,-15}", this._name, this._contactNumber, this._costPerDay, this._ownerName);
    }	
}
