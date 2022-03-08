/*

    Write a C# program to display  all the details in Customer class using Reflection.

    Sample Input and Output:
    Customer Details
    Menu
    1.Attributes
    2.Methods
    3.Constructor
    4.Exit
    1
    Attributes present in Customer class
    String Name
    Int64 MobileNumber
    String Username
    String Password
    Menu
    1.Attributes
    2.Methods
    3.Constructor
    4.Exit
    2
    Methods present in Customer class
    String get_Name
    Void set_Name
    Int64 get_MobileNumber
    Void set_MobileNumber
    String get_Username
    Void set_Username
    String get_Password
    Void set_Password
    Void Login
    Void Logout
    Customer AddCustomer
    Boolean RemoveCustomer
    Void DisplayCustomers
    Boolean Equals
    Int32 GetHashCode
    Type GetType
    String ToString
    Menu
    1.Attributes
    2.Methods
    3.Constructor
    4.Exit
    3
    Constructors present in Customer class
    Void .ctor(String, Int64, String, String)
    Void .ctor(String, Int64, String)
    Menu
    1.Attributes
    2.Methods
    3.Constructor
    4.Exit
    4
*/

using System;
using System.Reflection;

namespace reflection_demo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Customer Details");
            int choice;
            do
            {
                Console.WriteLine("Menu\n1.Attributes\n2.Methods\n3.Constructor\n4.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                //Fill your code here
                Type t = typeof(Customer);
                MemberInfo[] memberInfos = t.GetMembers(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                switch (choice) {
                    case 1:
                        Console.WriteLine("Attributes present in Customer class");
                        //Fill your code here
                        foreach(MemberInfo m in memberInfos)
                        {
                            if(m.MemberType == MemberTypes.Property)
                            {
                                Console.WriteLine($"{((PropertyInfo)m).PropertyType.Name} {((PropertyInfo)m).Name}");
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Methods present in Customer class");
                        //Fill your code here
                        foreach(MemberInfo m in memberInfos)
                        {
                            if(m.MemberType == MemberTypes.Method)
                            {
                                Console.WriteLine($"{((MethodInfo)m).ReturnType.Name} {((MethodInfo)m).Name}");
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Constructors present in Customer class");
                        //Fill your code here
                        foreach(MemberInfo m in memberInfos)
                        {
                            if(m.MemberType == MemberTypes.Constructor)
                            {
                                Console.WriteLine($"{m}");
                            }
                        }
                        break;
                    case 4:
                        break;
                }
            } while (choice > 0 && choice < 4);
        }
    }
}
