using System;

class Program
{
    public static void Main(string[] args)
    {

    }

    static void CharacterPattern()
    {
        //Fill your code here
        int rows = Convert.ToInt32(Console.ReadLine());
        int i, j;
        for (i = 1; i <= rows; i++)
        {
            for (j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void HazeCraftClientSeries()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int primeCount = 0;
        int i = 2;
        while (primeCount < n)
        {
            if (IsPrime(i))
            {
                Console.Write($"{i} ");
                primeCount++;
            }
            i++;
        }
    }
    public static bool IsPrime(int n)
    {
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static void AayushScholarship()
    {
        //Fill your code here
        int[] subjectMarks = new int[5];
        int totalMarks = 0;
        string res = "No";
        bool execallanceFlag = false;
        bool failureFlag = false;
        double grade = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Enter the subject{i + 1} mark");
            subjectMarks[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < 5; i++)
        {
            if (subjectMarks[i] == 2)
            {
                failureFlag = true;
            }
            if (subjectMarks[i] == 5)
            {
                execallanceFlag = true;
            }
            totalMarks += subjectMarks[i];
        }
        grade = (double)totalMarks / 5;
        if (grade >= 4 && execallanceFlag && !failureFlag)
        {
            res = "Yes";
        }
        Console.WriteLine(res);
    }

    static void TicketType()
    {
        //Fill your code here
        int age = Convert.ToInt32(Console.ReadLine());
        if(age >= 15)
        {
            Console.WriteLine("Adult Ticket");
        }
        else
        {
            Console.WriteLine("ChildTicket");
        }
    }
}