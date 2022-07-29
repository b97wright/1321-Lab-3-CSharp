/*
    Class: 1321L
    Section: Section W#1 C#
    Term: Spring 2022
    Instructor: Gayathri Yella
    Name: Brandon Wright
    Lab#: 3A
 */

using System;

namespace Lab3
{
    class Lab3A
    {
        static void Main(string[] args)
        {
            string uI;

            double ammountOwed, APR, minimumPayment, monthlyPer;

            Console.Write("Amount owed: $");
            uI = Console.ReadLine();
            ammountOwed = Convert.ToDouble(uI);

            Console.Write("APR: ");
            uI = Console.ReadLine();
            APR = Convert.ToDouble(uI);

            minimumPayment = ammountOwed * (APR / 12) * .01;
            monthlyPer = APR / 12;

            Console.WriteLine("Monthly percentage rate: " + Math.Round(monthlyPer, 6));
            Console.WriteLine("Minimum payment: $" + Math.Round(minimumPayment, 5));
        }
    }
}
