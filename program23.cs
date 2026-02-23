using System;

class ElectricityBill
{
    static void Main()
    {
        double units, billAmount = 0, fixedCharge = 50, gst = 0, totalBill;

        Console.Write("Enter total units consumed: ");
        units = Convert.ToDouble(Console.ReadLine());

        // Slab Calculation
        if (units <= 100)
        {
            billAmount = units * 1.5;
        }
        else if (units <= 200)
        {
            billAmount = (100 * 1.5) + ((units - 100) * 2.5);
        }
        else
        {
            billAmount = (100 * 1.5) + (100 * 2.5) + ((units - 200) * 4);
        }

        // Add Fixed Meter Charge
        billAmount += fixedCharge;

        // Apply GST if bill > 500
        if (billAmount > 500)
        {
            gst = billAmount * 0.18;
        }

        totalBill = billAmount + gst;

        Console.WriteLine("\n----- Electricity Bill -----");
        Console.WriteLine("Units Consumed: " + units);
        Console.WriteLine("Bill Amount (Before GST): ₹" + billAmount);
        Console.WriteLine("GST (18% if applicable): ₹" + gst);
        Console.WriteLine("Total Bill Amount: ₹" + totalBill);
    }
}