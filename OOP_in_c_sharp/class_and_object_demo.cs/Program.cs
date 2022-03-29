using System;

public class Animal
{
    private string _name;
    private int _numberOfLegs;
    private string _habitat;

    public string Name 
    {
        get
        {
            return _name;
        }
        set 
        {
            this._name = value;
        }
    }

    public int NumberOfLegs 
    {
        get
        {
            return _numberOfLegs;
        }
        set 
        {
            this._numberOfLegs = value;
        }
    }

    public string Habitat 
    {
        get
        {
            return _habitat;
        }
        set 
        {
            this._habitat = value;
        }
    }

    public Animal (string name, int numberOfLegs, string habitat)
    {
        Name = name;
        NumberOfLegs = numberOfLegs;
        Habitat = habitat;
    }

    public void DisplayAnimal()
    {
        Console.WriteLine($"animal {_name} has {_numberOfLegs} legs with habitat {_habitat}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal("tiger", 4, "forest");
        animal.DisplayAnimal();
        animal.Name = "lion";
        animal.DisplayAnimal();
        animal.Name = "monkey";
        animal.NumberOfLegs = 2;
        animal.DisplayAnimal();
        animal.Name = "fish";
        animal.NumberOfLegs = 0;
        animal.Habitat = "water";
        animal.DisplayAnimal();
    }
}