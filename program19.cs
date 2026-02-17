using System;

class PasswordValidation
{
    static void Main()
    {
        string password;
        bool isValid = false;

        while (!isValid)
        {
            Console.Write("Enter your password: ");
            password = Console.ReadLine();

            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;
            bool hasSpecial = false;

            if (password.Length >= 8)
            {
                foreach (char ch in password)
                {
                    if (char.IsUpper(ch))
                        hasUpper = true;
                    else if (char.IsLower(ch))
                        hasLower = true;
                    else if (char.IsDigit(ch))
                        hasDigit = true;
                    else
                        hasSpecial = true;
                }

                if (hasUpper && hasLower && hasDigit && hasSpecial)
                {
                    isValid = true;
                    Console.WriteLine("Password is valid ✅");
                }
                else
                {
                    Console.WriteLine("Password must contain:");
                    Console.WriteLine("- At least one uppercase letter");
                    Console.WriteLine("- At least one lowercase letter");
                    Console.WriteLine("- At least one digit");
                    Console.WriteLine("- At least one special character");
                }
            }
            else
            {
                Console.WriteLine("Password must be at least 8 characters long.");
            }

            Console.WriteLine();
        }
    }
}
