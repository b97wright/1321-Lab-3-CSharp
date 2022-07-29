/*
    Class: 1321L
    Section: Section W#1 C#
    Term: Spring 2022
    Instructor: Gayathri Yella
    Name: Brandon Wright
    Lab#: 3B
*/

using System;

namespace Lab3
{
    class Lab3B
    {
        static void Main(string[] args)
        {
            string uI;

            double credits, hours, qualityPoints, totalHours, GPA;

            Console.Write("Course 1 hours: ");
            uI = Console.ReadLine();
            hours = Convert.ToInt32(uI);

            Console.Write("Grade for course 1: ");
            uI = Console.ReadLine();
            credits = Convert.ToInt32(uI);

            qualityPoints = hours * credits;
            totalHours = hours;

            Console.Write("Course 2 hours: ");
            uI = Console.ReadLine();
            hours = Convert.ToInt32(uI);

            Console.Write("Grade for course 2: ");
            uI = Console.ReadLine();
            credits = Convert.ToInt32(uI);

            qualityPoints = qualityPoints + (hours * credits);
            totalHours = totalHours + hours;

            Console.Write("Course 3 hours: ");
            uI = Console.ReadLine();
            hours = Convert.ToInt32(uI);

            Console.Write("Grade for course 3: ");
            uI = Console.ReadLine();
            credits = Convert.ToInt32(uI);

            qualityPoints = qualityPoints + (hours * credits);
            totalHours = totalHours + hours;

            Console.Write("Course 4 hours: ");
            uI = Console.ReadLine();
            hours = Convert.ToInt32(uI);

            Console.Write("Grade for course 4: ");
            uI = Console.ReadLine();
            credits = Convert.ToInt32(uI);

            qualityPoints = qualityPoints + (hours * credits);
            totalHours = totalHours + hours;

            Console.WriteLine("Total hours is: " + totalHours);
            Console.WriteLine("Total quality points is: " + qualityPoints);

            GPA = qualityPoints / totalHours;

            Console.WriteLine("Your GPA for this semester is " + Math.Round(GPA, 5));
        }
    }
}
