/*
Write a C# program to display the full name of data type and class name assembly.

Sample Input and Output 1:

Menu
1.int
2.double
3.string
4.Program
1
mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089

 

Sample Input and Output 2:

Menu
1.int
2.double
3.string
4.Program
4
Program, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

 

Sample Input and Output 3:

Menu
1.int
2.double
3.string
4.Program
5
Invalid input


*/
using System;
using System.Reflection;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Menu\n1.int\n2.double\n3.string\n4.Program");
        int choice = Convert.ToInt32(Console.ReadLine());
        //Fill your code here
        switch (choice)
        {
            case 1:
                try
                {
                    Type type = typeof(int);
                    Assembly assembly = Assembly.GetAssembly(type);
                    Console.WriteLine($"{assembly.FullName}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                break;

            case 2:
                try
                {
                    Type type = typeof(double);
                    Assembly assembly = Assembly.GetAssembly(type);
                    Console.WriteLine($"{assembly.FullName}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                break;

            case 3:
                try
                {
                    Type type = typeof(string);
                    Assembly assembly = Assembly.GetAssembly(type);
                    Console.WriteLine($"{assembly.FullName}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                break;

            case 4:
                try
                {
                    Type type = typeof(Program);
                    Assembly assembly = Assembly.GetAssembly(type);
                    Console.WriteLine($"{assembly.FullName}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                break;

            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
}
