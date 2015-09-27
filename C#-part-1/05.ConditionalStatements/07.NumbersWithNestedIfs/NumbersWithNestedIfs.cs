﻿/*Problem 7. Sort 3 Numbers with Nested Ifs

Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.
Note: Don’t use arrays and the built-in sorting functionality.
*/

using System;

class NumbersWithNestedIfs
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a first number :");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a second number :");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a third number :");
        double c = double.Parse(Console.ReadLine());

        if (a > b)
        {
            if (a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("{0},{1},{2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0},{1},{2}", a, c, b);
                }
            }
            else
            {
                Console.WriteLine("{0},{1},{2}", c, a, b);
            }
        }
        else if (b > c)
        {
            if (a > c)
            {
                Console.WriteLine("{0},{1},{2}", b, a, c);
            }
            else
            {
                Console.WriteLine("{0},{1},{2}", b, c, a);
            }
        }
        else
        {
            Console.WriteLine("{0},{1},{2}", c, b, a);
        }

    }
}
    

    

