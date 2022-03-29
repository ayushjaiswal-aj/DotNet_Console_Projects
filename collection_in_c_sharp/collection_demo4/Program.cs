using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        HallBO hallBO = new HallBO();
        List<Hall> hallList = new List<Hall>();
        bool isExit = false;
        while (true)
        {
            Console.WriteLine("1.Add Hall\n2.Remove Hall\n3.Exit\nEnter the choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter hall detail:");
                    string hallDetail = Console.ReadLine();
                    //fill code here
                    Hall hall = hallBO.CreateHall(hallDetail);
                    if(hall != null)
                    {
                        hallList.Add(hall);
                        Console.WriteLine("Hall Created Successfully");
                    }
                    break;
                case 2:
                    //fill code here
                    if(hallList.Count > 0)
                    {
                        Console.WriteLine($"Total {hallList.Count} Halls");
                        Console.WriteLine("Enter the index:");
                        int index = Convert.ToInt32(Console.ReadLine());
                        hallBO.RemoveHallFromList(hallList, index);
                        if(hallList.Count == 0)
                        {
                            Console.WriteLine("Hall list empty");
                        }
                        else
                        {
                            hallBO.DisplayHalls(hallList);
                        }
                    }
                    else
                    {
                        Console.WriteLine("List is Empty");
                        isExit = true;
                        break;
                    }

                    break;
                case 3:
                    isExit = true;
                    break;
            }
            if (isExit)
                break;
        }
    }
}