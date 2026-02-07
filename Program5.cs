using System;

namespace RelationalOperators
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            string input1 = Console.ReadLine();
            int num1 = Convert.ToInt32(input1);

            Console.WriteLine("Enter the second number:");
            string input2 = Console.ReadLine();
            int num2 = Convert.ToInt32(input2);

            bool isEqual = num1 == num2;
            bool isNotEqual = num1 != num2;
            bool isGreater = num1 > num2;
            bool isLess = num1 < num2;
            bool isGreaterOrEqual = num1 >= num2;
            bool isLessOrEqual = num1 <= num2;

            Console.WriteLine("1. Equal to (==): " + isEqual);
            Console.WriteLine("2. Not Equal to (!=): " + isNotEqual);
            Console.WriteLine("3. Greater than (>): " + isGreater);
            Console.WriteLine("4. Less than (<): " + isLess);
            Console.WriteLine("5. Greater than or Equal to (>=): " + isGreaterOrEqual);
            Console.WriteLine("6. Less than or Equal to (<=): " + isLessOrEqual);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}