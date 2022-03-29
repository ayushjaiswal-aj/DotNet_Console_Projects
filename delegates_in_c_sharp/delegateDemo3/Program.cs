using System;
using System.Collections.Generic;

//Declare delegate

public delegate bool FilterEligiblePeople(Citizen citizen, int minAge, int maxAge);

public class Program
{
    static void Main(string[] args)
    {
        Citizen p = new Citizen();
        Console.WriteLine("Enter the citizen details");
        Console.WriteLine("Enter the name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the age");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the min age");
        int minAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the max age");
        int maxAge = Convert.ToInt32(Console.ReadLine());
        //Fill your code
        p.Age = age;
        p.Name = name;
        FilterEligiblePeople filterEligiblePeople = new FilterEligiblePeople(Citizen.IsEligible);
        Citizen.CheckPeopleEligible(p, minAge, maxAge, filterEligiblePeople);
    }
}