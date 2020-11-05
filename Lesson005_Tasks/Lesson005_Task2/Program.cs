using System;

namespace Lesson005_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int square = 8;
            int rectangle1 = 6, rectangle2 = 18;
            int trapeze1 = 6, trapeze2 = 13, trapeze_h = 8;

            Console.WriteLine("Square");
            for (int i = 0; i < square; i++)
            {
                for (int j = 0; j < square; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }

            Console.WriteLine("Rectangle");
            for (int i = 0; i < rectangle1; i++)
            {
                for (int j = 0; j < rectangle2; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }

            Console.WriteLine("Trapeze");
            for (int i = 0; i < trapeze_h; i++)
            {
                if (trapeze1 <= trapeze2)
                {
                    for (int j = 0; j < trapeze1; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.Write("\n");
                    trapeze1++;
                }
                else
                    break;
            }
        }
    }
}
