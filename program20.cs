using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int original = num;
        int reverse = 0;

        while (num > 0)
        {
            int remainder = num % 10;
            reverse = reverse * 10 + remainder;
            num = num / 10;
        }

        if (original == reverse)
            Console.WriteLine("Number is Palindrome");
        else
            Console.WriteLine("Number is Not Palindrome");
    }
}