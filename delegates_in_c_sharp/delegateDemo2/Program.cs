using System;

//fill code here

public delegate int calculateDelegate(int x, int y);
class Program
{
    public static int Addition(int num1, int num2)
    {
        return num1 + num2;
    }

    public static int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }
    public static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }
    public static int Divide(int num1, int num2)
    {
        return num1 / num2;
    }

    static void Main(string[] args)
    {
        //fill code here
        int num1, num2, ch;
        calculateDelegate cd;
        Program program = new Program();
        Console.WriteLine("Enter the num1");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the num2");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Menu\n" +
            "1.Addition\n" +
            "2.Subtraction\n" +
            "3.Multiplication\n" +
            "4.Division");
        ch = Convert.ToInt32(Console.ReadLine());
        switch (ch)
        {
            case 1:
                cd = new calculateDelegate(Addition);
                Console.WriteLine($"Addition of {num1} and {num2} is {cd(num1, num2)}");
                break;

            case 2:
                cd = new calculateDelegate(Subtract);
                Console.WriteLine($"Subtraction of {num1} and {num2} is {cd(num1, num2)}");
                break;

            case 3:
                cd = new calculateDelegate(Multiply);
                Console.WriteLine($"Multiplication of {num1} and {num2} is {cd(num1, num2)}");
                break;

            case 4:
                cd = new calculateDelegate(Divide);
                Console.WriteLine($"Division of {num1} and {num2} is {cd(num1, num2)}");
                break;
        }
    }
}
