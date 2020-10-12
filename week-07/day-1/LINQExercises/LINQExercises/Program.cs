using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace LINQExercises
{
    class Fox
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public string Color { get; private set; }
        public Fox(string name, string type, string color)
        {
            Name = name;
            Type = type;
            Color = color;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            // Write a LINQ Expression to get the even numbers from the following array:
            //int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            //var evenNumbers = n.Where(n => n % 2 == 0).ToArray();
            // PrintNumArray(evenNumbers);

            // Exercise 2
            // Write a LINQ Expression to get the average value of the odd numbers from the following array:

            //int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            //var averageOddNumber = n.Where(n => n % 2 == 1).Average();
            //Console.WriteLine(averageOddNumber);

            // Exercise 3
            // Write a LINQ Expression to get the squared value of the positive numbers from the following array:
            //int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            //var squaredPositive = n.Where(n => n >= 0).Select(n => n * n).ToArray();
            //PrintNumArray(squaredPositive);

            // Exercise 4
            // Write a LINQ Expression to find which number squared value is more then 20 from the following array:

            //int[] n = new[] { 3, 9, 2, 8, 6, 5 };
            //var squared20AndHigher = n.Where(n => n * n > 20).ToArray();
            //PrintNumArray(squared20AndHigher);

            // Exercise 5
            // Write a LINQ Expression to find the frequency of numbers in the following array:

            //int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            //var numbersFrequency = n.GroupBy(n => n).Select(g => $"Number {g.Key} is {g.Count()} times");
            //numbersFrequency.ToList().ForEach(n => Console.WriteLine(n));

            // Exercise 6
            // Write a LINQ Expression to find the frequency of characters in a given string.
            //string text = "Write a LINQ Expression to find the frequency of characters in a given string.";
            //var charactersFrequency = text.Where(ch => Char.IsLetterOrDigit(ch)).GroupBy(ch => ch).Select(g => $"Letter {g.Key} is {g.Count()} times");
            //charactersFrequency.ToList().ForEach(l => Console.WriteLine(l));

            // Exercise 7
            // Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:

            //string[] cities = { "ROME", "LONDON", "AIROBI", "CALIFORNIA", "ZURICH", "AEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            //var citiesAToI1 = cities.Where(c => c[0].Equals('A') && c[c.Length - 1].Equals('I'));
            //var citiesAToI2 = cities.Where(c => c.StartsWith("A") && c.EndsWith("I"));
            //citiesAToI1.ToList().ForEach(c => Console.WriteLine(c));

            // Exercise 8
            // Write a LINQ Expression to find the uppercase characters in a string.
            //string text = "Write a LINQ Expression to find the fRequency of Characters in a givEn string.";
            //var charactersUpper = text.Where(ch => Char.IsUpper(ch)).Select(letter => $"Letter {letter} is uppercase");
            //charactersUpper.ToList().ForEach(l => Console.WriteLine(l));

            // Exercise 9
            // Write a LINQ Expression to convert a char array to a string.
            //char[] letters = new char[] { 'a', 'h', 'o', 'j' };
            //var word = letters.ForEach(l => word += l);
            //Console.WriteLine(word);

            // Exercise 10
            // Create a Fox class with 3 properties: name, type and color.
            // Fill a list with at least 5 foxes, it's up to you how you name/create them.
            // Write a LINQ Expression to find the foxes with green color.
            // Write a LINQ Expression to find the foxes with green color and pallida type.

            List<Fox> foxes = new List<Fox>()
            {
            new Fox("Fox1", "pallida", "sandy"),
            new Fox("Fox2", "vulpes", "red"),
            new Fox("Fox3", "chama", "orange"),
            new Fox("Fox4", "vulpes", "green"),
            new Fox("Fox5", "pallida", "white"),
            new Fox("Fox6", "chama", "orange"),
            new Fox("Fox7", "vulpes", "grey"),
            new Fox("Fox8", "vulpes", "white"),
            new Fox("Fox9", "chama", "yellow"),
            new Fox("Fox10", "pallida", "green")};

            var greenFox = foxes.Where(f => f.Color == "green");
            var greenFoxPallida = foxes.Where(f => f.Color == "green" && f.Type == "pallida");

        }
        public static void PrintNumArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
                if (i < numbers.Length - 1)
                {
                    Console.Write(",");
                }
            }
        }
    }
}
