using System;
using System.Collections.Generic;

class HallBO
{
    public Hall CreateHall(string hallDetails)
    {
        //fill code here
        string[] details = hallDetails.Split(',');
        Hall hall = new Hall(details[0], details[1], Convert.ToDouble(details[2]), details[3]);
        return hall;
    }
    public bool RemoveHallFromList(List<Hall> hallList, int index)
    {
        //fill code here
        if(hallList.Count <= 0)
        {
            return false;
        }
        hallList.RemoveAt(index-1);
        return true;

    }
    public void DisplayHalls(List<Hall> hallList)
    {
        Console.WriteLine("{0}{1,15}{2,15}{3,15}", "Name", "Contact Number", "Cost per day", "Owner Name");
        //fill code here
        foreach(Hall hall in hallList)
        {
            Console.WriteLine("{0}{1,15}{2,15}{3,15}", hall.Name, hall.ContactNumber, hall.CostPerDay, hall.OwnerName);
        }
    }
}