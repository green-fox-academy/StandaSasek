using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Number adder
            // Write a recursive function that takes one parameter: n and adds numbers from 1 to n.

            // Console.WriteLine("Result of number adding is {0}", NumberAdder(5));

            // Sum Digits
            // Given a non - negative integer n, return the sum of its digits recursively(without loops).

            /*int n = 15;
            Console.WriteLine("Sum digits of {0} is {1}", n, SumDigits(n));*/

            // Power
            // Given base and n that are both 1 or more, compute recursively(no loops) the value of base to the n power, so powerN(3, 2) is 9(3 squared).

            /* int baseNumber = 2;
             int n = 4;
             Console.WriteLine("The {0} power of {1} is {2}.", n, baseNumber, Power(baseNumber, n));*/

            // Greatest Common Divisor
            // Find the greatest common divisor of two numbers using recursion.

            /* int one = 49;
             int two = 21;
             Console.WriteLine("Greatest common divider of {0} and {1} is {2}", one, two, GTC(one, two));*/

            // Bunnies
            // We have a number of bunnies and each bunny has two big floppy ears.We want to compute the total number of ears across 
            // all the bunnies recursively(without loops or multiplication).

            /*int bunnies = 50;
            Console.WriteLine("{0} of our bunnies have a total of {1} ears.", bunnies, BunniesEars(bunnies));*/

            // Bunnies again
            // We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies(1, 3, ..) have the normal 2 ears.
            // The even bunnies(2, 4, ..) we'll say have 3 ears, because they each have a raised foot. Recursively return the number 
            // of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).

            /*int bunnies = 4;
            Console.WriteLine("{0} of our extra bunnies have a total of {1} ears.", bunnies, BunniesEarsExtra(bunnies));*/

            // Strings
            // Given a string, compute recursively(no loops) a new string where all the lowercase 'x' chars have been changed 
            // to 'y' chars.

            /* var word = "XNOT is Whx not";
             Console.WriteLine(XreplacedByY(word));*/

            // Strings again
            // Given a string, compute recursively a new string where all the 'x' chars have been removed.

            /*var word = "XNOT is Whx not";
            Console.WriteLine(Xremoved(word)); // Removes both 'X' and 'x'*/

            // Strings again and again
            // Given a string, compute recursively a new string where all the adjacent chars are now separated by a *

            /*var word = "Hello";
            Console.WriteLine(AddStar(word));*/


        }
        private static string AddStar(string word)
        {
            if (word.Length <= 1)
            {
                return word;
            }
            else
            {
                return word.Substring(0, 1) + "*" + AddStar(word.Substring(1));
            }
        }

        private static string Xremoved(string word)
        {
            if (!word.ToLower().Contains("x"))
            {
                return word;
            }
            else if (word.ToLower().Substring(0, 1) == ("x"))
            {
                if (word.Length == 1)
                {
                    return word.Substring(0, 1).Remove(0, 1);
                }
                return word.Substring(0, 1).Remove(0, 1) + Xremoved(word.Substring(1));
            }
            else
            {
                return word.Substring(0, 1) + Xremoved(word.Substring(1));
            }
        }
        private static string XreplacedByY(string word)
        {
            if (!word.Contains("x"))
            {
                return word;
            }
            else if (word.Substring(0, 1) == ("x"))
            {
                if (word.Length == 1)
                {
                    return word.Substring(0, 1).Replace("x", "y");
                }
                return word.Substring(0, 1).Replace("x", "y") + XreplacedByY(word.Substring(1));
            }
            else
            {
                return word.Substring(0, 1) + XreplacedByY(word.Substring(1));
            }
        }
        private static int BunniesEarsExtra(int bunnies)
        {
            if (bunnies == 0)
            {
                return 0;
            }
            else if (bunnies % 2 == 0)
            {
                return 3 + BunniesEarsExtra(bunnies - 1);
            }
            else
            {
                return 2 + BunniesEarsExtra(bunnies - 1);
            }
        }
        private static int BunniesEars(int bunnies)
        {
            if (bunnies == 0)
            {
                return 0;
            }
            else
            {
                return 2 + BunniesEars(bunnies - 1);
            }
        }
        private static int GTC(int one, int two)
        {
            if (one % two == 0)
            {
                return two;
            }
            else
            {
                int temp = one % two;
                one = two;
                two = temp;
                return GTC(one, two);
            }
        }
        private static int Power(int baseNumber, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return baseNumber * Power(baseNumber, n - 1);
            }
        }
        private static int SumDigits(int n)
        {
            if (n < 10)
            {
                return n;
            }
            else
            {
                return n % 10 + SumDigits((n - (n % 10)) / 10);
            }
        }

        private static int NumberAdder(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n + NumberAdder(n - 1);
            }
        }
    }
}
