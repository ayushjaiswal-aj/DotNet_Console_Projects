using System;
using System.Reflection;

class Program
    {
        static void Main(string[] args)
        {
            // fill code here
            Type songType = typeof(Song);
            
            Console.WriteLine("Virtual properties in type Song");
            foreach (MethodInfo m in songType.GetMethods())
            {
                if(m.IsAbstract)
                {
                    Console.WriteLine($"{m.Name} (type {m.ReturnType})");
                }
            }
        }
    }