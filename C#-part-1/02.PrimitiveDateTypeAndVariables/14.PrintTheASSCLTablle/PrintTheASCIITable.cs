﻿/*Problem 14.* Print the ASCII Table

Write a program that prints the visible characters of the ASCII table on the console (characters from 33 to 126 including).
*/

using System;
class PrintTheASCIITable
    {
        static void Main()
        {
             for (int i = 33; i <= 126; i++)
             {
                Console.Write((char)i);
             }
        }
    }   
