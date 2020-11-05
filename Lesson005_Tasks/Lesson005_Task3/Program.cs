using System;
using System.Text;

namespace Lesson005_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int try_numb = 0;

            while (try_numb < 5)
            {
                Console.WriteLine("Загадка: Хто завжди правду каже?\nВідповідь (english) :");
                string answer = Console.ReadLine();
                //string correct_ans = "слід";

                if (answer == "Mirror" || answer == "mirror" || answer == "MIRROR" || answer == "mIRROR")
                {
                    Console.WriteLine("Відповідь правильна!");
                    break;
                }
                else if (answer == "" || answer == " ")
                {
                    Console.WriteLine("Порожній рядок!");
                    try_numb++;
                    Console.WriteLine($"Кількість спроб = {try_numb}");
                    continue;
                }
                else
                {
                    Console.WriteLine("Відповідь неправильна, спробуйте ще раз!");
                    try_numb++;
                    Console.WriteLine($"Кількість спроб = {try_numb}");
                    continue;
                }
            }
            if(try_numb==5)
                Console.WriteLine("Кількість спроб закінчилась!");
        }
    }
}
