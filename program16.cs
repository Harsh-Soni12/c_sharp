using System;

class PrimeBetweenTwoNumbers
{
    static void Main()
    {
        int start, end;

        Console.Write("Enter starting number: ");
        start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter ending number: ");
        end = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Prime numbers between " + start + " and " + end + " are:");

        for (int i = start; i <= end; i++)
        {
            if (i < 2)
                continue;

            bool isPrime = true;

            for (int j = 2; j <= i / 2; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
                Console.WriteLine(i);
        }
    }
}
