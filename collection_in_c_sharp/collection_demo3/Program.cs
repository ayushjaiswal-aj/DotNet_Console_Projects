using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {    
        Console.WriteLine("Enter the number of details:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the address details:");
        Dictionary<string, List<Address>> d = new Dictionary<string, List<Address>>();
            
        for (int i = 0; i < n; i++)
        {
            //fill your code here
            string[] addresses = Console.ReadLine().Split(',');
            Address address = new Address(addresses[0], addresses[1], addresses[2], addresses[3], Convert.ToInt32(addresses[4]));
            if(d.ContainsKey(address.City))
            {
                List<Address> addressList = d[address.City];
                addressList.Add(address);
            }
            else
            {
                List<Address> addressList = new List<Address>();
                addressList.Add(address);
                d.Add(address.City, addressList);
            }
        }
        Console.WriteLine("Enter the city to view:");
        string city = Console.ReadLine();
        //fill your code here
        if (d.ContainsKey(city))
        {
            Console.WriteLine("Address Details:");
            Console.WriteLine(String.Format("{0,-30} {1,-30} {2,-15} {3,-15} {4,-10}", "Address1", "Address2", "City", "State", "Pincode"));
            List<Address> cityAddresses = d[city];
            foreach (Address address in cityAddresses)
            {
                Console.WriteLine($"{address.ToString()}");
            }
        }
        else
        {
            Console.WriteLine("Address Details for the selected city not found...");
        }
    }
}
