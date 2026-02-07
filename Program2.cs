using System;
namespace grade
{
    class Program2
    {
        static void Main(string[] args)
        {
            int totalSemesters = 4;
            int subjectsPerSem = 5;

            int grandTotal = 0;
            int maxMarks = totalSemesters * subjectsPerSem * 100;

            Console.WriteLine("----- STUDENT RESULT (SEM 1 TO SEM 4) -----\n");

            for (int sem = 1; sem <= totalSemesters; sem++)
            {
                Console.WriteLine("Enter marks for Semester " + sem);

                int semesterTotal = 0;

                for (int sub = 1; sub <= subjectsPerSem; sub++)
                {
                    Console.Write("Subject " + sub + " marks: ");
                    int marks = Convert.ToInt32(Console.ReadLine());

                    semesterTotal = semesterTotal + marks;
                }

                Console.WriteLine("Semester " + sem + " Total: " + semesterTotal + "\n");

                grandTotal = grandTotal + semesterTotal;
            }

            double percentage = (grandTotal * 100.0) / maxMarks;

            Console.WriteLine("----- FINAL RESULT -----");
            Console.WriteLine("Total Marks : " + grandTotal + " / " + maxMarks);
            Console.WriteLine("Percentage  : " + percentage.ToString("0.00") + "%");

            if (percentage >= 40)
            {
                Console.WriteLine("Result      : PASS");
            }
            else
            {
                Console.WriteLine("Result      : FAIL");
            }

            Console.ReadLine();
        }
    }
}
