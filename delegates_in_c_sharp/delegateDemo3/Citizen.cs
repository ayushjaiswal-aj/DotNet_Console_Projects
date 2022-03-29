using System;
using System.Collections.Generic;

public class Citizen
{
    string _name;
    int _age;

    public string Name
    {
        get
        {
            return this._name;
        }
        set
        {
            this._name = value;
        }
    }

    public int Age
    {
        get
        {
            return this._age;
        }
        set
        {
            this._age = value;
        }
    }

    public static bool IsEligible(Citizen p, int min, int max)
    {
        //fill code here
        return p.Age >= min && p.Age <= max;
    }

    public static void CheckPeopleEligible(Citizen citizen, int minAge, int maxAge, FilterEligiblePeople filter)
    {
        //fill code here
        if(filter(citizen, minAge, maxAge))
        {
            Console.WriteLine($"Citizen {citizen.Name} is eligible");
        }
        else
        {
            Console.WriteLine($"Citizen {citizen.Name} is not eligible");
        }
    }
}