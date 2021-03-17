using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string nick1, nick2;
            Console.WriteLine("Игрок 1, введите свой никнейм");
            nick1 = Console.ReadLine();
            Console.WriteLine("Игрок 2, введите свой никнейм");
            nick2 = Console.ReadLine();
            bool f = true;
            Random rand = new Random();
            int n = rand.Next(20, 31), m;
            while (n > 0)
            {
                Console.WriteLine(n);
                Console.WriteLine("{0}, ваш ход", f ? nick1 : nick2);
                if (f)
                {
                    m = int.Parse(Console.ReadLine());
                    while (!(m >= 1 && m <= 4))
                    {
                        Console.WriteLine("Некорректный ход! {0}, повторите ввод", f ? nick1 : nick2);
                        m = int.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    m = rand.Next(1, 5); // от 1 до 4 включительно
                    Console.WriteLine(nick2 + " походил " + m);
                }

                n -= m;
                f = !f;
            }
            Console.WriteLine(0);
            Console.WriteLine("{0} победил!", f ? nick2 : nick1);
            Console.ReadKey();
        }
    }
}
