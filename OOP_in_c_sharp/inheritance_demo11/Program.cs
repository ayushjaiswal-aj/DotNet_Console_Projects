using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        //Fill your code here

        Console.WriteLine("Enter the name");
        string name = Console.ReadLine();
        Console.WriteLine("Ente the city");
        string city = Console.ReadLine();
        Console.WriteLine("Enter the number of flights per day");
        int flightsPerDay = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of passengers travelling in each flight");
        int passengersPerFlight = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of cargo units shipped in each flight");
        int cargoUnitsPerFlight = Convert.ToInt32(Console.ReadLine());
        CommercialServiceAirport cosa = new CommercialServiceAirport("code", name, city, flightsPerDay, passengersPerFlight);
        CargoServiceAirport casa = new CargoServiceAirport("code", name, city, flightsPerDay, cargoUnitsPerFlight);
        Console.WriteLine("Airport Details");
        Console.WriteLine($"Airport Name : {name}\n" +
            $"Location : {city}\n" +
            $"Number of flights per day : {flightsPerDay}\n" + 
            $"Number of passengers travelling in each flight per day : {passengersPerFlight}\n" + 
            $"Number of cargo units shipped in each flight per day : {cargoUnitsPerFlight}");
    }
}




