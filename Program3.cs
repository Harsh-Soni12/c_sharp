using System;

namespace ArithmeticOperations
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            string input1 = Console.ReadLine();
            double number1 = Convert.ToDouble(input1);

            Console.WriteLine("Enter the second number:");
            string input2 = Console.ReadLine();
            double number2 = Convert.ToDouble(input2);

            double addition = number1 + number2;
            double subtraction = number1 - number2;
            double multiplication = number1 * number2;
            double division = number1 / number2;
            double modulus = number1 % number2;

            Console.WriteLine("Addition Result: " + addition);
            Console.WriteLine("Subtraction Result: " + subtraction);
            Console.WriteLine("Multiplication Result: " + multiplication);
            Console.WriteLine("Division Result: " + division);
            Console.WriteLine("Modulus (Remainder) Result: " + modulus);
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}