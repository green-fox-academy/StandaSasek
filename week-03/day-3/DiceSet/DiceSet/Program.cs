using System;

namespace DiceSet
{
    class Program
    {
        static void Main(string[] args)
        {

            // You have a `DiceSet` class which has a list for 6 dice
            // You can roll all of them with roll()
            // Check the current rolled numbers with getCurrent()
            // You can reroll with reroll()
            // Your task is to roll the dice until all of the dice are 6
            DiceSet diceSet = new DiceSet();

            WriteNumbers(diceSet);
            diceSet.Roll();
            WriteNumbers(diceSet);
            Only6Back(diceSet);
            Console.WriteLine();
            WriteNumbers(diceSet);

        }
        public static void WriteNumbers(DiceSet name)
        {
            //Console.Clear();
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Dice {0}. = {1}", i + 1, name.GetCurrent(i));
            }
            Console.ReadLine();
        }
        public static void Only6Back(DiceSet name)
        {
            name.Roll();
            for (int i = 0; i < 6; i++)
            {
                while (name.GetCurrent(i) != 6)
                {
                    name.Reroll(i);
                    Console.WriteLine("Dice {0}. = {1}", i + 1, name.GetCurrent(i));
                }
                Console.WriteLine("Dice {0}. = {1}", i + 1, name.GetCurrent(i));
            }
        }
    }
}

