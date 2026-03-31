using System;


interface Exam
{
    bool Pass(int mark);
}


interface Classify
{
    string Division(int average);
}


class Result : Exam, Classify
{
    
    public bool Pass(int mark)
    {
        if (mark >= 50)
            return true;
        else
            return false;
    }

    
    public string Division(int average)
    {
        if (average >= 60)
            return "First";
        else if (average >= 50)
            return "Second";
        else
            return "Fail";
    }
}


class Program
{
    static void Main()
    {
        Result r = new Result();

        Console.Write("Enter marks: ");
        int marks = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter average: ");
        int avg = Convert.ToInt32(Console.ReadLine());

        bool result = r.Pass(marks);

        Console.WriteLine("Pass Status: " + result);
        Console.WriteLine("Division: " + r.Division(avg));
    }
}





