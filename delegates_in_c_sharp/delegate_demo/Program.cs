using System;

class Program
{
    //fill code here
    public delegate void rectangleDelegate(double height, double width);

    public void PrintArea(double height, double width)
    {
        //fill code here
        Console.WriteLine($"Area is: {height * width}");
    }

    public void PrintPerimeter(double height, double width)
    {
        //fill code here
        double perimeter = (2 * height) + (2 * width);
        Console.WriteLine($"Perimeter is: {perimeter}");
    }

    static void Main(string[] args)
    {
        //fill code here
        Program program = new Program();
        rectangleDelegate rectDel1 = new rectangleDelegate(program.PrintArea);
        rectangleDelegate rectDel2 = new rectangleDelegate(program.PrintPerimeter);
        Console.WriteLine("Enter the width");
        double width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the height");
        double height = Convert.ToDouble(Console.ReadLine());
        rectDel1 (height, width);
        rectDel2 (height, width);

    }
}
