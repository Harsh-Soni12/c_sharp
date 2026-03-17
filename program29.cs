using System;

class Rectangle
{
    double length;
    double width;

    public Rectangle()
    {
        length = 0;
        width = 0;
    }

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    public double Area()
    {
        return length * width;
    }

    public void Display()
    {
        Console.WriteLine("Length: " + length);
        Console.WriteLine("Width: " + width);
        Console.WriteLine("Area: " + Area());
    }
}

class Program
{
    static void Main()
    {
        Rectangle r1 = new Rectangle();
        Console.WriteLine("Rectangle using Default Constructor");
        r1.Display();

        Console.WriteLine();

        Rectangle r2 = new Rectangle(10, 5);
        Console.WriteLine("Rectangle using Parameterized Constructor");
        r2.Display();
    }
}