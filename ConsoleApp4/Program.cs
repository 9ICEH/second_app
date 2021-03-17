using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. New Game\n" +
                              "2. Load Game\n" +
                              "3. Exit Game\n");
            string choice = Console.ReadLine();
            bool correctChoice = false;
            Hero newHero = new Hero();
            while (correctChoice == false)
            {
                switch (choice)
                {
                    case "1":

                        CharacterCreation.createChar(newHero);
                        correctChoice = true;
                        break;
                    case "2":
                        Console.WriteLine("This feature is not yet implemented.");
                        correctChoice = false;
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter a correct value.");
                        break;
                }
                if (correctChoice == true)
                    break;
                else
                    choice = Console.ReadLine();
            }
            Console.WriteLine("\n Your character is {0}, a {1}.", newHero.heroName, newHero.heroClass);

            Console.ReadLine();
        }
    }

    class CharacterCreation
    {
        public static void createChar(Hero newHero)
        {
            Console.WriteLine("\n We will proceed in character creation.");
            Console.WriteLine("Please enter your character name:");
            newHero.heroName = Console.ReadLine();

            Console.WriteLine("\nNow choose your character's class: \n" +
                              "Warrior......1\n" +
                              "Mage........2\n" +
                              "Rogue........3");
            string classChoice = Console.ReadLine();
            bool correctChoice = false;
            while (correctChoice == false)
            {
                switch (classChoice)
                {
                    case "1":
                        newHero.heroClass = "Warrior";
                        correctChoice = true;
                        break;
                    case "2":
                        newHero.heroClass = "Mage";
                        correctChoice = true;
                        break;
                    case "3":
                        newHero.heroClass = "Rogue";
                        correctChoice = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a correct value.");
                        break;
                }
                if (correctChoice == false)
                    classChoice = Console.ReadLine();
                else break;
            }
            Hero.ClassSelect(newHero);
        }
    }

    class Character
    {
        public int charHealth, charMaxHealth, charStr, charInt, charAgi;
    }

    class Hero : Character
    {
        public string heroName, heroClass;
        public int level, experience, gold;

        public static void ClassSelect(Hero newHero)
        {
            newHero.charAgi = 10;
            newHero.charInt = 10;
            newHero.charMaxHealth = 100;
            newHero.experience = 0;
            newHero.gold = 0;
            newHero.level = 1;

            switch (newHero.heroClass)
            {
                case "Warrior":
                    newHero.charMaxHealth = newHero.charMaxHealth * 115 / 100;
                    newHero.charStr = newHero.charStr * 12 / 100;
                    break;
                case "Mage":
                    newHero.charInt = newHero.charInt * 12 / 100;
                    break;
                case "Rogue":
                    newHero.charAgi = newHero.charAgi * 12 / 100;
                    break;
            }
            newHero.charHealth = newHero.charMaxHealth;
        }
    }
}
