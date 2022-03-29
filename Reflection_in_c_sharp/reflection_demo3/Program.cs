using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        //Fill your code here
        String className;
        Console.WriteLine("Enter the class name:");
        className = Console.ReadLine();
        Type myType = Type.GetType(className);
        Console.WriteLine($"Class Full Name: {myType.FullName}");
        Console.WriteLine($"Base Type: {myType.BaseType}");
        Console.WriteLine($"Is Class: {myType.IsClass}");
        Console.WriteLine($"Is Interface: {myType.IsInterface}");
    }
}
