using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int rows, seatsPerRow;
        List<List<Seat>> seats = new List<List<Seat>>();
        Console.WriteLine("Enter the number of rows");
        //fill code here
        rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of seats per row");
        //fill code here
        seatsPerRow = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the seats to book");
        //fill code here
        List<string> bookingSeats = (Console.ReadLine().Split(",")).ToList();
        List<string> invalidSeats = new List<string>();
        for (int i = 0; i < rows; i++)
        {
            List<Seat> rowSeats = new List<Seat>();
            for (int j = 0; j < seatsPerRow; j++)
            {
                Seat seat = new Seat((char)(i + 65), j + 1, false);
                rowSeats.Add(seat);
            }
            seats.Add(rowSeats);
        }

        foreach (string seatString in bookingSeats)
        {
            int seatNo = Convert.ToInt32(seatString[1]) - 49;
            int sectionNo = ((int)seatString[0]) - 65;
            if (seatNo >= seatsPerRow || seatNo < 0 || sectionNo >= rows || sectionNo < 0)
            {
                invalidSeats.Add(seatString);
                continue;
            }
            seats[sectionNo][seatNo].Booked = true;
        }

        foreach (string seatString in invalidSeats)
        {
            Console.WriteLine($"Invalid seat number {seatString}");
        }

        Console.WriteLine("Booked Seats");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < seatsPerRow; j++)
            {
                if (seats[i][j].Booked)
                {
                    Console.Write("- ");
                }
                else
                {
                    Console.Write($"{(char)seats[i][j].Section}{seats[i][j].Number} ");
                }
            }
            Console.WriteLine();
        }
    }
}