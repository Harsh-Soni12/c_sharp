using System;
namespace area_circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, area;

            Console.Write("Enter Radius: ");
            r = Convert.ToDouble(Console.ReadLine());

            area = 3.14 * r * r;

            Console.WriteLine("Area of Circle = " + area);
            Console.ReadLine();
        }
    }
}
