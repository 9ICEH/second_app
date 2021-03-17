using System;

namespace ConsoleApp3
{
    class Program
    {
   
             }

    private static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Изначально у тебя есть две шкалы здоровья (две переменных). В них по 100 hp
          
            int heroes;
            heroes = 100; // hp
            //const string HEROES_HP = "Герой 100";
            Console.WriteLine(heroes);

            int enemy;
            enemy = 100; // hp
            //const string ENEMY_HP = "Враг 100";
            Console.WriteLine(enemy);

            // Запросить ввести слово "kick" и твой игрок бьет врага.
            // Если ты ошибаешься и вводишь другой слово, то игрок промахивается.

            Console.Write("Введите kick : ");
            Console.ReadLine();
            string intup = Console.ReadLine();
            //Random rnd = new Random();
           // {
              //  int value = random.Next(0, 20);
           // }

            bool correctInput = true;
            //decimal damage;
            while (correctInput == false) // удар и промахи
            {
            switch (intup)
            {
                case "kick":
                    correctInput = true;
                    // const decimal HIT_THE_ENEMY = enemy - random.Next(0, 20);
                    break;

                default:
                    Console.WriteLine("Вы промахнулись");
                    break; 
            }
            }
            //После того как игрок произвел удар или промахнулся, то враг автоматически бьет тебя.
            //Враг не может промахнуться.
            //Каждый удар будет отнимать от 5 до 20 hp.
           
            //Сценарий:
            //-игрок вводит слово "kick" и бьет на 10 hp(случайное от 5 до 20).
            //У врага стало 90 hp.
            //Потом враг бьет игрока на 15 hp.
            //Игрок вводит слово отличное от kick и программа говорит о том, что игрок промахнулся.
            //Снова бьет враг.
            //Игра продолжается, пока один из игроков не умрет, т.е.hp меньше или равно 0.

            //Создание объекта для генерации чисел
            // Random rnd = new Random();

            //Получить случайное число (в диапазоне от 0 до 10)
            //int value = random.Next(0, 20);
            Console.ReadKey();
        }
    }
