using System;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (; ; )
            {
                if (i == 5)
                     continue;
                Console.WriteLine("Квадрат числа {0} равен {1}", ++i, i * i);
            }

            Console.ReadKey();
        }
    }
}
