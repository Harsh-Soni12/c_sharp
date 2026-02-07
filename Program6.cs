using System;
namespace compound_intrest
{
    class Program6
    {
        static void Main(string[] args)
        {
            double p, r, t, ci;

            Console.Write("Enter Principal: ");
            p = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Rate: ");
            r = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Time: ");
            t = Convert.ToDouble(Console.ReadLine());

            ci = p * Math.Pow((1 + r / 100), t) - p;

            Console.WriteLine("Compound Interest = " + ci);
            Console.ReadLine();
        }
    }
}
