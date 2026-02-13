using System;

class Program
{
    static void Main()
    {
        // Step 1: Declare variables
        int a = 10;
        float b = 5.5f;

        float result1;
        int result2;

        // 🔹 Automatic Conversion (Implicit Conversion)
        // int automatically converts to float
        result1 = a + b;

        // 🔹 Force Conversion (Explicit Conversion)
        // float forcibly converted to int
        result2 = a + (int)b;

        // Output
        Console.WriteLine("Integer value: " + a);
        Console.WriteLine("Float value: " + b);

        Console.WriteLine("\nAfter Automatic Conversion (a + b): " + result1);
        Console.WriteLine("After Force Conversion (a + (int)b): " + result2);
    }
}
