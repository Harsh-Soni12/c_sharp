using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        string reverse = "";

        for (int i = str.Length - 1; i >= 0; i--)
        {
            reverse += str[i];
        }

        if (str.Equals(reverse, StringComparison.OrdinalIgnoreCase))
            Console.WriteLine("String is Palindrome");
        else
            Console.WriteLine("String is Not Palindrome");
    }
}