using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //Fill Your Code Here

        HashSet<string> users = new HashSet<string>();
        Console.WriteLine("Enter the size of the user list");
        int userListSize = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < userListSize; i++)
        {
            users.Add(Console.ReadLine());
        }
        Console.WriteLine($"Total number of unique users {users.Count}");
    }
}