using System;

interface IResult
{
    bool Pass(int mark);
}

interface IDivision
{
    string Division(int average);
}

class StudentResult : IResult, IDivision
{
    public bool Pass(int mark)
    {
        if (mark >= 35)
            return true;
        else
            return false;
    }

    public string Division(int average)
    {
        if (average >= 60)
            return "First Division";
        else if (average >= 50)
            return "Second Division";
        else if (average >= 35)
            return "Third Division";
        else
            return "Fail";
    }
}

class Program
{
    static void Main(string[] args)
    {
        StudentResult s = new StudentResult();

        Console.Write("Enter marks: ");
        int mark = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter average: ");
        int average = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Pass Status: " + s.Pass(mark));
        Console.WriteLine("Division: " + s.Division(average));
    }
}