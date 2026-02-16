using System;

class Program
{
    static void Main()
    {
        int n;

        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());

        int first = 0;
        int second = 1;
        int next;

        Console.WriteLine("Fibonacci Series up to " + n + " is:");

        if (n >= 0)
        {
            Console.Write(first + " ");
        }

        if (n >= 1)
        {
            Console.Write(second + " ");
        }

        next = first + second;

        while (next <= n)
        {
            Console.Write(next + " ");
            first = second;
            second = next;
            next = first + second;
        }
    }
}
