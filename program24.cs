using System;

class BillDiscount
{
    static void Main()
    {
        double amount, discount = 0;
        string category;

        Console.Write("Enter total bill amount: ");
        amount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter customer category (senior / regular / industrial): ");
        category = Console.ReadLine().ToLower();

        if (category == "senior")
        {
            discount = amount * 0.20;   // 20% discount
        }
        else if (category == "regular")
        {
            discount = amount * 0.10;   // 10% discount
        }
        else if (category == "industrial")
        {
            discount = amount * 0.15;   // 15% discount
        }
        else
        {
            Console.WriteLine("Invalid category!");
            return;
        }

        double finalAmount = amount - discount;

        Console.WriteLine("Discount: " + discount);
        Console.WriteLine("Final Bill Amount: " + finalAmount);
    }
}