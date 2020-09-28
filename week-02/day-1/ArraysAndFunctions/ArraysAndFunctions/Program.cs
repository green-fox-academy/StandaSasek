using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
// using System.Linq;
using System.Net.WebSockets;
using System.Text;

namespace ArraysAndFunctions
{
    internal class Program
    {

        private static void Main(string[] args)
        {
            // THIRD
            // - Create an array variable named `numbers`
            //   with the following content: `[4, 5, 6, 7]`
            // - Print the third element of `numbers`

            /*int[] numbers = { 4, 5, 6, 7 };
            Console.WriteLine(numbers[2]);
            Console.ReadLine();*/

            // COMPARE LENGTH
            // - Create an array variable named `firstArrayOfNumbers`
            //   with the following content: `[1, 2, 3]`
            // - Create an array variable named `secondArrayOfNumbers`
            //   with the following content: `[4, 5]`
            // - Print "secondArrayOfNumbers is longer" if
            //   `secondArrayOfNumbers` has more elements than
            //   `firstArrayOfNumbers`

            /*int[] firstArrayOfNumbers = { 1, 2, 3 };
            int[] secondArrayOfNumbers = { 4, 5 };

            if (firstArrayOfNumbers.Length < secondArrayOfNumbers.Length)
            {
                Console.WriteLine("secondArrayOfNumbers is longer");
            } else
            {
                Console.WriteLine("firstArrayOfNumbers is longer");
            }
            Console.ReadLine();*/

            // SUM ELEMENTS
            // - Create an array variable named `numbers`
            //   with the following content: `[54, 23, 66, 12]`
            // - Print the sum of the second and the third element

            /*int[] numbers = { 54, 23, 66, 12 };

            Console.WriteLine(numbers[1] + numbers[2]);
            Console.ReadLine();*/

            // - Create an array variable named `numbers`
            //   with the following content: `[1, 2, 3, 8, 5, 6]`
            // - Change the 8 to 4
            // - Print the fourth element
            /*int[] numbers = { 1, 2, 3, 8, 5, 6 };
            numbers[3] = 4;
            Console.WriteLine(numbers[3]);
            Console.ReadLine();*/

            // INCREMENT ELEMENT
            //- Create an array variable named `numbers`
            //  with the following content: `[1, 2, 3, 4, 5]`
            //- Increment the third element
            //- Print the third element

            /* int[] numbers = { 1, 2, 3, 4, 5 };
             numbers[2]++;
             Console.WriteLine(numbers[2]);
             Console.ReadLine();*/

            // PRINT ALL
            // - Create an array variable named `numbers`
            //   with the following content: `[4, 5, 6, 7]`
            // - Print all the elements of `numbers`

            /* int[] numbers = { 1, 2, 3, 4, 5 };
             foreach (var number in numbers)
             {
                 Console.WriteLine(number);
             }
             Console.ReadLine();*/

            // MATRIX
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output

            /* int[,] numbers = new int[4, 4];

             for (int row = 0; row < 4; row++)
             {
                 for (int col = 0; col < 4; col++)
                 {
                     if (row != col)
                     {
                         numbers[row, col] = 0;
                     } else
                     {
                     numbers[row, col] = 1;
                     }
                 }
             }
             for (int row = 0; row < numbers.GetLength(0); row++)
             {
                 for (int col = 0; col < numbers.GetLength(1); col++)
                 {
                     Console.Write(numbers[row,col] + " ");
                 }
                 Console.WriteLine();
             }
             Console.ReadLine();*/

            // DOUBLE ITEMS
            // - Create an array variable named `numList`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Double all the values in the array

            /*int[] numbers = { 3, 4, 5, 6, 7 };
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= 2;
            }
            Array.ForEach(numbers, Console.WriteLine);
            Console.ReadLine();*/

            // COLORS
            // - Create a two dimensional array
            //   which can contain the different shades of specified colors
            // - In `colors[0]` store the shades of green:
            //   `"lime", "forest green", "olive", "pale green", "spring green"`
            // - In `colors[1]` store the shades of red:
            //   `"orange red", "red", "tomato"`
            // - In `colors[2]` store the shades of pink:
            //   `"orchid", "violet", "pink", "hot pink"`

            /*string[,] colors = new string[3, 5]
            {
                 { "lime", "forest green", "olive", "pale green", "spring green"},
                 { "orange red", "red", "tomato", null, null},
                 { "orchid", "violet", "pink", "hot pink", null}
            };
            for (int row = 0; row < colors.GetLength(0); row++)
            {
                for (int col = 0; col < colors.GetLength(1); col++)
                {
                    Console.Write(colors[row, col] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();*/

            // APPEND A
            // - Create an array variable named `animals`
            //   with the following content: `["koal", "pand", "zebr"]`
            // - Add all elements an `"a"` at the end

            /*string[] animals = new string[3] { "koal", "pand", "zebr" };
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i] += "a";
            }
            Array.ForEach(animals, Console.WriteLine);

            Console.ReadLine();*/

            // SWAP ELEMENTS
            // - Create an array variable named `orders`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `orders`

            /*string[] orders = new string[3] { "first", "second", "third" };

            string temp = orders[0];
            orders[0] = orders[2];
            orders[2] = temp;

            Array.ForEach(orders, Console.WriteLine);

            Console.ReadLine();*/

            // SUM ALL
            // - Create an array variable named `numbers`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Print the sum of the elements in `numbers`

            /*int[] numbers = { 3, 4, 5, 6, 7 };
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
            Console.ReadLine();*/

            // REVERSE LIST
            // - Create an array variable named `numbers`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `numbers`
            // - Print the elements of the reversed `numbers`

            /*int[] numbers = { 3, 4, 5, 6, 7 };

            for (int i = 0; i < (numbers.Length / 2); i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = temp;
            }
            Array.ForEach(numbers, Console.WriteLine);
            Console.ReadLine();*/

            // DOUBLING
            // - Create an integer variable named `baseNum` and assign the value `123` to it
            // - Create a function called `Doubling` that doubles it's input parameter and returns with an integer
            // - Print the result of `Doubling(baseNum)`

            /* int baseNum = 123;

             Console.WriteLine(Doubling(baseNum));
             Console.ReadLine();*/

            // GREETER FUNCTION
            // - Create a string variable named `al` and assign the value `Green Fox` to it
            // - Create a function called `Greet` that greets it's input parameter
            //     - Greeting is printing e.g. `Greetings dear, Green Fox`
            // - Greet `al`

            /*string al = "Green Fox";

            Console.WriteLine(Greet(al));
            Console.ReadLine();*/

            // APPEND A
            // - Create a string variable named `typo` and assign the value `Chinchill` to it
            // - Write a function called `AppendAFunc` that gets a string as an input,
            //   appends an 'a' character to its end and returns with a string
            // - Print the result of `AppendAFunc(typo)`

            /*string typo = "Chinchill";

            Console.WriteLine(AppendFunc(typo));
            Console.ReadLine();*/

            // SUMMING
            // Write a function called `sum` that returns the sum of numbers from zero to the given parameter

            /* Console.WriteLine("Please write a number: ");
             string inputNumber = Console.ReadLine();
             bool isInputCorrect = double.TryParse(inputNumber, out double number);

             Console.WriteLine(Sum(number));
             Console.ReadLine();*/

            // FACTORIAL
            // - Create a function called `Factorio`
            //   that returns it's input's factorial

            /*Console.WriteLine("Please write a number: ");
            string inputNumber = Console.ReadLine();
            bool isInputCorrect = double.TryParse(inputNumber, out double number);

            Console.WriteLine(Factorio(number));
            Console.ReadLine();*/

            // FIND A PART OF INTEGER
            //  Create a function that takes a number and an array of integers as a parameter
            //  Returns the indices of the integers in the array of which the first number is a part of
            //  Or returns an empty array if the number is not part of any of the integers in the array

            /*//  Example:
            Console.WriteLine(SubInt(1, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: `[0, 1, 4]`
            Console.WriteLine(SubInt(9, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: '[]'*/

            // Not able to go through with the type of return - void does not work (only CW) ...

            // UNIQUE
            //  Create a method that takes an array of integers as a parameter
            //  Returns an array of integers where every integer occurs only once

            //  Example

            // Console.WriteLine(Unique(new[] { 1, 11, 34, 11, 52, 61, 1, 34 }));
            // should print: `[1, 11, 34, 52, 61]`

            // ANAGRAM
            // Create a function named is anagram following your current language's style guide. It should take two strings and return a boolean value depending on whether its an anagram or not.
            // Examples
            // input 1 input 2 output
            // "dog"   "god"   true
            // "green" "fox"   false

            /* Console.WriteLine(Anagram("dog", "god"));
             Console.WriteLine(Anagram("green", "tax"));
             */

            // PALINDROME BUILDER
            // Create a function named create palindrome following your current language's style guide. It should take a string, create a palindrome from it and then return it.
            // Examples
            // input   output
            // ""  ""
            //"greenfox"  "greenfoxxofneerg"
            //"123"   "123321"

            /*Console.WriteLine(PalindromeBuilder("Šašek"));
            Console.WriteLine(PalindromeBuilder("greenfox"));
            Console.WriteLine(PalindromeBuilder("123"));*/

            // PALINDROME SEARCHER
            // Create a function named search palindrome following your current language's style guide. It should take a string, search for palindromes that at least 3 characters long and return a list with the found palindromes.
            //Examples
            //input   output
            //"dog goat dad duck doodle never"["og go", "g g", " dad ", "dad", "d d", "dood", "eve"]
            //"apple"[]
            //"racecar"["racecar", "aceca", "cec"]
            //""[]

            // PalindromeSearcher("dog goat dad duck doodle never"); // works well for our examples, do not work for Palindrome sentences, like "Murder for a jar of red rum."

        }
        public static void PalindromeSearcher(String words)
        {
            List<string> results = new List<string>();
            words.ToLower();
            for (int i = 1; i < words.Length - 1; i++)
            {
                int indexToStart = 0;
                int lengthOfPalin = 0;
                int letterFromIndex = 1;
                while (i - letterFromIndex >= 0 && i + letterFromIndex < words.Length) // palindromes with the odd length 
                {
                    if (words[i - letterFromIndex] != words[i + letterFromIndex])
                    {
                        letterFromIndex += words.Length;
                        break;
                    }
                    else
                    {
                        indexToStart = i - letterFromIndex;
                        lengthOfPalin = (letterFromIndex * 2) + 1;
                        string palin = words.Substring(indexToStart, lengthOfPalin);
                        results.Add(palin);
                    }
                    letterFromIndex++;
                }
                letterFromIndex = 1;
                if (words[i] == words[i + letterFromIndex])
                {
                    while (i - letterFromIndex >= 0 && i + letterFromIndex + 1 < words.Length) // palindromes with the even length 
                    {
                        if (words[i - letterFromIndex] != words[i + letterFromIndex + 1])
                        {
                            letterFromIndex += words.Length;
                            break;
                        }
                        else
                        {
                            indexToStart = i - letterFromIndex;
                            lengthOfPalin = (letterFromIndex * 2) + 2;
                            string palin = words.Substring(indexToStart, lengthOfPalin);
                            results.Add(palin);
                        }
                        letterFromIndex++;
                    }
                }
            }
            Console.Write("[");
            foreach (var result in results)
            {
                Console.Write($"\"{result}\", ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
        public static string PalindromeBuilder(string word)
        {
            var palindrome = word;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                palindrome += word[i];
            }
            return palindrome;
        }
        public static bool Anagram(string word1, string word2)
        {
            if (word1.Length != word2.Length)
            {
                return false;
            }
            var sample1 = word1.ToLower().ToCharArray();
            Array.Sort(sample1);
            var sample2 = word2.ToLower().ToCharArray();
            Array.Sort(sample2);
            for (int i = 0; i < sample1.Length; i++)
            {
                if (sample1[i] != sample2[i])
                {
                    return false;
                }
            }
            return true;
        }
        public static string Unique(int[] array)
        {
            var unique = new List<int>();
            unique.Add(array[0]);
            for (int i = 0; i < array.Length; i++)
            {
                bool isUnique = true;
                foreach (var item in unique)
                {
                    if (array[i] == item)
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    unique.Add(array[i]);
                }
            }
            var result = $"[{String.Join(", ", unique)}]";
            return result;
        }
        public static void SubInt(int num01, int[] array01)
        {
            string[] numbersStrings = Array.ConvertAll(array01, number => number.ToString());
            List<int> indexes = new List<int> { };

            for (int i = 0; i < numbersStrings.Length; i++)
            {
                if (numbersStrings[i].Contains(num01.ToString()))
                {
                    indexes.Add(i);
                }
            }
            foreach (var index in indexes)
            {
                Console.Write(indexes[index]);
            }
        }
        public static double Factorio(double num01)
        {
            double factor = 1;
            for (int i = 1; i <= num01; i++)
            {
                factor = factor * i;
            }
            return factor;
        }
        public static double Sum(double num01)
        {
            double sumOfAll = 0;
            for (int i = 0; i <= num01; i++)
            {
                sumOfAll += i;
            }
            return sumOfAll;
        }
        public static string AppendFunc(string str01)
        {
            return str01 += "a";
        }
        public static string Greet(string str01)
        {
            return "Greetings dear, " + str01;
        }

        public static int Doubling(int num01)
        {
            return num01 *= 2;
        }

    }
}