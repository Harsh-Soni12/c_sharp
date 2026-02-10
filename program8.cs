
using System;

class CircleArea
{
    static void Main()
    {
        Console.Write("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = 3.14 * radius * radius;

        Console.WriteLine("Area of the circle is: " + area);
    }
}
