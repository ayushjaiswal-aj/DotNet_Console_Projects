using System;
class Program {
	public static void Main(string[] args) {
		Console.WriteLine("Enter the length of the rectangle");
		int length = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the width of the rectangle");
		int width = Convert.ToInt32(Console.ReadLine());
		Rectangle rectangle = new Rectangle(length, width);
		rectangle.Display();
		Console.WriteLine("Enter the new dimension");
		int newDimention = Convert.ToInt32(Console.ReadLine());
		Rectangle newRectangle = rectangle.DimensionChange(newDimention);
		newRectangle.Display();
		//Fill your code here
	}
}