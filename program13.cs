using System;

class FactorialProgram
{
    static void Main()
    {
        int number, factorial = 1;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            factorial = factorial * i;
        }

        Console.WriteLine("Factorial of " + number + " is: " + factorial);
    }
}
