using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int original = num;
        int sum = 0;
        int digits = num.ToString().Length;

        while (num > 0)
        {
            int remainder = num % 10;
            sum += (int)Math.Pow(remainder, digits);
            num = num / 10;
        }

        if (original == sum)
            Console.WriteLine("Number is Armstrong");
        else
            Console.WriteLine("Number is Not Armstrong");
    }
}