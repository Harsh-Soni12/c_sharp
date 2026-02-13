using System;

class LoginCheck
{
    static void Main()
    {
        string correctUser = "admin";
        string correctPass = "1540";

        int attempts = 3;

        while (attempts > 0)
        {
            Console.Write("Enter username: ");
            string? user = Console.ReadLine();

            Console.Write("Enter password: ");
            string? pass = Console.ReadLine();

            if (user == correctUser && pass == correctPass)
            {
                Console.WriteLine("Login successful");
                break;
            }
            else
            {
                attempts--;
                Console.WriteLine("Invalid login details");

                if (attempts > 0)
                {
                    Console.WriteLine("Remaining attempts: " + attempts);
                }
                else
                {
                    Console.WriteLine("Login blocked");
                }
            }
        }
    }
}
