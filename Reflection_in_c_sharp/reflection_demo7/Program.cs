/*
Write a C# program to display the method name and return type present in Song or Customer class using Reflection.

Sample Input and Output :

Enter the class name
Customer
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
String ToString
Boolean Equals
Int32 GetHashCode
Type GetType

 
*/

using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        //Fill your code here
        Console.WriteLine("Enter the class name");
        string className = Console.ReadLine();
        Type t = Type.GetType(className);
        MemberInfo[] memberInfos = t.GetMembers(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
        foreach (MemberInfo m in memberInfos)
        {
            if (m.MemberType == MemberTypes.Method)
            {
                Console.WriteLine($"{((MethodInfo)m).ReturnType.Name} {((MethodInfo)m).Name}");
            }
        }
    }
}