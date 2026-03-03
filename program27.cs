using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[8];
        int positiveCount = 0;
        int negativeCount = 0;

        Console.WriteLine("Enter 8 numbers:");

        for (int i = 0; i < 8; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < 8; i++)
        {
            if (numbers[i] > 0)
                positiveCount++;
            else if (numbers[i] < 0)
                negativeCount++;
        }

        Console.WriteLine("Positive numbers: " + positiveCount);
        Console.WriteLine("Negative numbers: " + negativeCount);
    }
}