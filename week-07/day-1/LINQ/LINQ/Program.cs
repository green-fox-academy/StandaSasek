using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        public class Pirate
        {
            public String Name { get; private set; }
            public int HP { get; private set; }
            public List<string> Drinks { get; set; }
        }
        static void Main(string[] args)
        {
            var pirate = new Pirate();
            pirate.Drinks = new List<string>() { "beer", "beer", "rum" };
            var numbers = new List<Pirate> { pirate };
            var numbersArray = new Pirate[] { new Pirate() };
            WriteNumbers(numbersArray);
        }
        public static void WriteNumbers(IEnumerable<Pirate> input)
        {
            /*var names = new List<string>();
            foreach (var pirate in input)
            {
                names.Add(pirate.Name);
            }
            //The same code in short by LINQ
            var namesLinq = input.Select(p => p.Name);*/

            /* var hpSumForEach = 0;
             foreach (var pirate in input)
             {
                 hpSumForEach += pirate.HP;
             }
             //The same code in short by LINQ
             var HpSum = input.Sum(p => p.HP);*/

            /* var hpSumForEach = 0;
             foreach (var pirate in input)
             {
                 if (pirate.HP < 20)
                 {
                     hpSumForEach += pirate.HP;
                 }
             }
             //The same code in short by LINQ
             var HpSum = input.Where(p => p.HP < 20).Sum(p => p.HP);*/
        }
    }
}
