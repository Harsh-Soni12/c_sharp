using System;

class Employee
{
    int employeeId;
    string name;
    double salary;

    public Employee()
    {
        employeeId = 0;
        name = "Unknown";
        salary = 0;
    }

    public Employee(int id, string n, double s)
    {
        employeeId = id;
        name = n;
        salary = s;
    }

    public double CalculateAnnualSalary()
    {
        return salary * 12;
    }

    public void Display()
    {
        Console.WriteLine("Employee ID: " + employeeId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Monthly Salary: " + salary);
        Console.WriteLine("Annual Salary: " + CalculateAnnualSalary());
    }
}

class Program
{
    static void Main()
    {
        Employee e1 = new Employee();
        Employee e2 = new Employee(101, "Rahul", 25000);

        e1.Display();
        Console.WriteLine();
        e2.Display();
    }
}