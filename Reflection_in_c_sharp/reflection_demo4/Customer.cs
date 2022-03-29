using System;
using System.Collections.Generic;
using System.Text;

class Customer
{
    private string _name;
    private long _mobileNumber;
    private string _username;
    private string _password;

    public string Name { get => _name; set => _name = value; }
    public long MobileNumber { get => _mobileNumber; set => _mobileNumber = value; }
    public string Username { get => _username; set => _username = value; }
    public string Password { get => _password; set => _password = value; }

    public Customer(string name, long mobileNumber, string username, string password)
    {
        Name = name;
        MobileNumber = mobileNumber;
        Username = username;
        Password = password;
    }

    public Customer(string name, long mobileNumber, string username)
    {
        Name = name;
        MobileNumber = mobileNumber;
        Username = username;
    }

    public void Login()
    {
        Console.WriteLine("Login successful");
    }

    public void Logout()
    {
        Console.WriteLine("Thank You");
    }

    public Customer AddCustomer(string customerDetails)
    {
        string[] splited = customerDetails.Split(',');
        return new Customer(splited[0], long.Parse(splited[1]), splited[2], splited[3]);
    }

    public bool RemoveCustomer(List<Customer> customerList, int index)
    {
        if (customerList.Count >= index)
        {
            customerList.RemoveAt(index - 1);
            return true;
        }
        return false;
    }
    public void DisplayCustomers(List<Customer> customerList)
    {
        Console.WriteLine("{0}{1,15}{2,15}{3,15}", "Name", "Mobile Number", "Username", "Password");
        foreach (Customer customer in customerList)
        {
            Console.WriteLine("{0}{1,15}{2,15}{3,15}", customer.Name, customer.MobileNumber, customer.Username, customer.Password);
        }
    }

}
