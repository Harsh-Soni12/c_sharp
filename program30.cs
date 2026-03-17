using System;

class Student
{
    int rollNo;
    string name;
    double marks;

    public Student()
    {
        rollNo = 0;
        name = "Unknown";
        marks = 0;
    }

    public Student(int r, string n, double m)
    {
        rollNo = r;
        name = n;
        marks = m;
    }

    public string CalculateGrade()
    {
        if (marks >= 75)
            return "A";
        else if (marks >= 60)
            return "B";
        else if (marks >= 50)
            return "C";
        else if (marks >= 35)
            return "D";
        else
            return "Fail";
    }

    public void Display()
    {
        Console.WriteLine("Roll No: " + rollNo);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Marks: " + marks);
        Console.WriteLine("Grade: " + CalculateGrade());
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student();
        Console.WriteLine("Student 1 Details:");
        s1.Display();

        Console.WriteLine();

        Student s2 = new Student(101, "Rahul", 82);
        Console.WriteLine("Student 2 Details:");
        s2.Display();
    }
}