using System;

class Hall
{
    private string _name;
	private string  _contactNumber;
	private double _costPerDay;
	private string _ownerName;
	
	public Hall() { }
	
	public Hall(string _name, string _contactNumber, double _costPerDay, string _ownerName) {
		this._name = _name;
		this._contactNumber = _contactNumber;
		this._costPerDay = _costPerDay;
		this._ownerName = _ownerName;
	}
	
	public string Name { get => this._name; set => this._name = value; }
	public string ContactNumber { get => this._contactNumber; set => this._contactNumber = value; }
	public double CostPerDay { get => this._costPerDay; set => this._costPerDay = value; }
	public string OwnerName { get => this._ownerName; set => this._ownerName = value; }
}