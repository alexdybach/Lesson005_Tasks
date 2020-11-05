using System;
using System.Text;

namespace Lesson005_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Кількість можливих варіантів номерного знаку з 5 цифр:\nP(5) = 5! = ");
            int n = 5, p = 1;

            for (int i = 1; i <= n; i++)
                p *= i;
            Console.WriteLine(p);
        }
    }
}
