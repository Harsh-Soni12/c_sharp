using System;

class Program
{
    static void Main()
    {
        int n, i;
        bool isPrime = true;

        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());

        if (n <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
            Console.WriteLine(n + " is a Prime Number");
        else
            Console.WriteLine(n + " is Not a Prime Number");
    }
}
