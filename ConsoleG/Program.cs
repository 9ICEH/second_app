using System;

namespace ConsoleG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Приветствие, ник и начало игры
            { 
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("*********************************\n" +
                                  "Добро пожаловать в симулятор боя.\n" +
                                  "*********************************");

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Нажмите Enter, для начала игры.");
                Console.ReadKey();

                string nickname;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Введите никнейм");
                nickname = Console.ReadLine();

                string nicknameEnemy;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введите имя врага");
                nicknameEnemy = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            // Изначально у тебя есть две шкалы здоровья (две переменных). В них по 100 hp
            
            int heroHp = 100; // hp
            Console.WriteLine(heroHp);

            int enemyHp;
            enemyHp = 100; // hp
            Console.WriteLine(enemyHp);

            // Запросить ввести слово "kick" и твой игрок бьет врага.
            // Если ты ошибаешься и вводишь другой слово, то игрок промахивается.

            // пока все живы - идет битва
            // bool battle = heroHp > 0 && enemyHp > 0;
            // while(battle)

            while (heroHp > 0 && enemyHp > 0)
            // тут битва
            {
                // прошу игрока ввести данные
                Console.Write("Для удара введите kick:  ");
                string input = Console.ReadLine();

                // проверяю, если это "kick" то наношу врагу урон
                // bool inputCorrect = input == "kick";
                // if (inputCorrect)

                if (input == "kick")
                {
                    Random rand = new Random();
                    int damage = rand.Next(5, 20);
                    enemyHp = enemyHp - damage;
                   //  Console.WriteLine($"Урон {damage}, осталось здоровья {enemyHp}");
                }
                // если это НЕ "kick" то не наношу урон, а пишу что промахнулся
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы промахнулись.");

                    Random rand = new Random();
                    int damage = rand.Next(5, 20);
                    heroHp = heroHp - damage;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    //Console.WriteLine($"Урон {damage}, осталось здоровья {heroHp}");

                    Console.WriteLine(enemyHp);
                    Console.WriteLine(heroHp);
                }

                // потом враг бьет меня
                if (input != "kick") // Добавляю || input == "kick" - подсчёта нет, а без него урон не проходит когда kick true
                {
                    Random rand = new Random();
                    int damage = rand.Next(5, 20);
                    heroHp = heroHp - damage;
                    //Console.WriteLine($"Урон {damage}, осталось здоровья {heroHp}");
                }
                else
                // Выводим показатели хп на экран
                {
                    Console.WriteLine(enemyHp);
                    Console.WriteLine(heroHp);
                }
                // Когда у одого хп больше 0, вывести на экран победителя
                while (heroHp <= 0 || enemyHp <= 0)

                    if (heroHp <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{enemyHp} Враг победил");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("***************************\n" +
                                          "***************************\n" +
                                          "=====G A M E   O V E R=====\n" +
                                          "***************************\n" +
                                          "***************************");
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{heroHp} Герой победил");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("***************************\n" +
                                          "***************************\n" +
                                          "=====G A M E   O V E R=====\n" +
                                          "***************************\n" +
                                          "***************************");
                        break;
                    }            
                            }
            //После того как игрок произвел удар или промахнулся, то враг автоматически бьет тебя.
            //Враг не может промахнуться.
            //Каждый удар будет отнимать от 5 до 20 hp.

            //Сценарий:
            // x
            //-игрок вводит слово "kick" и бьет на 10 hp(случайное от 5 до 20).
            //У врага стало 90 hp.
            //Потом враг бьет игрока на 15 hp.

            // x
            //Игрок вводит слово отличное от kick и программа говорит о том, что игрок промахнулся.
            //Снова бьет враг.
            //Игра продолжается, пока один из игроков не умрет, т.е.hp меньше или равно 0.

            Console.ReadKey();
        }
    }
}
