using System;
using System.Text;

namespace Lesson005_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("Введіть 2 цілих числа:  (щоб перше число було менше за друге!)");
                int numb1 = int.Parse(Console.ReadLine());
                int numb2 = int.Parse(Console.ReadLine());
                int numb = numb1;
                if (numb1 < numb2)
                {
                    while (numb < numb2 - 1)
                    {
                        numb++;
                        Console.WriteLine(numb);
                    }
                    break;
                }
                else
                    Console.WriteLine("Перше число більше за друге!");
            }

        }
    }
}
