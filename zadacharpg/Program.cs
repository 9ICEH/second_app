using System;

namespace zadacharpg
{
 

        // Изначально у тебя есть две шкалы здоровь (две переменных). В них по 100 hp

    class Person
    {
            string name;
            int attack;
            int health;

    Person(string _name, int _attack, int _health)
            {
                name = _name;
                attack = _attack;
                health = _health;
            }

     void PrintStats()
            {
                Console.WriteLine("{0} stats:", name);
                Console.WriteLine("");
                Console.WriteLine("Attack value is: {0}", attack);
                Console.WriteLine("Health value is: {0}", health);
            }

            public void NormAttack(Person target)
            {
                target.health -= attack;
            }
        }


        // Запросить ввести слово "kick" и твой игрок бьет врага.
        // Если ты ошибаешься и вводишь другой слово, то игрок промахивается.
        //После того как игрок произвел удар или промахнулся, то враг автоматически бьет тебя.
        //Враг не может промахнуться.


    }
            

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
            //int value = rnd.Next(0, 10);

