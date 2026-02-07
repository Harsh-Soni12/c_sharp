using System;

namespace SimpleInterestCalculator
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Principal Amount:");
            string pInput = Console.ReadLine();
            double principal = Convert.ToDouble(pInput);

            Console.WriteLine("Enter Rate of Interest (per year):");
            string rInput = Console.ReadLine();
            double rate = Convert.ToDouble(rInput);

            Console.WriteLine("Enter Time (in years):");
            string tInput = Console.ReadLine();
            double time = Convert.ToDouble(tInput);

            double simpleInterest = (principal * rate * time) / 100;

            double totalAmount = principal + simpleInterest;

            Console.WriteLine("Calculated Simple Interest: " + simpleInterest);
            Console.WriteLine("Total Amount (Principal + Interest): " + totalAmount);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}