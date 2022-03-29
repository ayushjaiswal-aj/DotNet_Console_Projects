using System;
public class Rectangle{
    private int _length;
    private int _width;
	
	//Fill your code here
	public int Length
    {
		get { return _length; }
		set { _length = value; }
    }

	public int Width
    {
		get { return _width; }
		set { _width = value; }
    }

	public Rectangle(int width, int length)
    {
		_width = width;
		_length = length;
    }

	public Rectangle()
    {
		
    }
	
	public int Area() {
		//Fill your code here
		return (_width * _length);
	}
	
	public void Display() {
		//Fill your code here
		Console.WriteLine("Rectangle Dimension");
		Console.WriteLine($"Lenght:{_length}");
		Console.WriteLine($"Width:{_width}");
		Console.WriteLine($"Area of the rectangle:{Area()}");
	}

	public Rectangle DimensionChange(int d) {
		//Fill your code here
		Rectangle obj = new Rectangle(_width * d, _length * d);
        	return obj;
	}
}
