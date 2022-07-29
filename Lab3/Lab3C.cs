/*
    Class: 1321L
    Section: Section W#1 C#
    Term: Spring 2022
    Instructor: Gayathri Yella
    Name: Brandon Wright
    Lab#: 3C
*/

using System;

namespace Lab3
{
    class Lab3C
    {
        static void Main(string[] args)
        {
            string uI;

            double numberOne, numberTwo, answer, count;
            bool isFound = false;

            Console.Write("Enter a number you want to find a multiple of: ");
            uI = Console.ReadLine();
            numberOne = Convert.ToDouble(uI);


            Console.Write("Enter a second number: ");
            uI = Console.ReadLine();
            numberTwo = Convert.ToDouble(uI);

            count = numberTwo;

            while (isFound == false)
            {
                answer = count % numberOne;

                if(answer == 0)
                {
                    isFound = true;
                }
                else
                {
                    count = count -1;
                }
            }
            

            Console.WriteLine(" ");
            Console.WriteLine(count);
            

        }
    }
}
