using System;
using System.Collections.Generic;
using System.Linq;

namespace _8kyu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Console.WriteLine(Check(new object[] { 66, 101 }, 66));
            //Console.WriteLine(Check(new object[] { 80, 117, 115, 104, 45, 85, 112, 115 }, 45));

            //Console.WriteLine(Check(new object[] { 't', 'e', 's', 't' }, 'e'));
            //Console.WriteLine(Check(new object[] { "what", "a", "great", "kata" }, "kat"));

            //Console.WriteLine(MakeNegative(42));
            //Console.WriteLine(MakeNegative(0));
            //Console.WriteLine(MakeNegative(-3));

            //(3, Persistence(39));
            //(0, Persistence(4));
            //(2, Persistence(25));
            //(4, Persistence(999));
            //persistence(39) == 3 // because 3*9 = 27, 2*7 = 14, 1*4=4
            //                     // and 4 has only one digit

            //persistence(999) == 4 // because 9*9*9 = 729, 7*2*9 = 126,
            //                      // 1*2*6 = 12, and finally 1*2 = 2

            //persistence(4) == 0 // because 4 is already a one-digit number

            //Console.WriteLine(Persistence(39));
            //Console.WriteLine(Persistence(4));
            //Console.WriteLine(Persistence(25));
            //Console.WriteLine(Persistence(999));

            //(1, rowSumOddNumbers(1));
            //(125, rowSumOddNumbers(5));
            //(74088, rowSumOddNumbers(42));

            //Console.WriteLine(rowSumOddNumbers(1));
            //Console.WriteLine(rowSumOddNumbers(5));
            //Console.WriteLine(rowSumOddNumbers(42));

            //("20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11", AlphabetPosition("The sunset sets at twelve o' clock."));
            //("20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20", AlphabetPosition("The narwhal bacons at midnight."));


            //Console.WriteLine(AlphabetPosition("The sunset sets at twelve o' clock."));
            //Console.WriteLine(AlphabetPosition("The narwhal bacons at midnight."));

            //Console.WriteLine(String.Join(", ", ArrayDiff(new int[] { 1, 2 }, new int[] { 1 })));
            //Console.WriteLine(String.Join(", ", ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 })));
            //Console.WriteLine(String.Join(", ", ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 2 })));
            //Console.WriteLine(String.Join(", ", ArrayDiff(new int[] { 1, 2, 2 }, new int[] { })));
            //Console.WriteLine(String.Join(", ", ArrayDiff(new int[] { }, new int[] { 1, 2 })));

            //MatrixAddition(
            //    new int[][] { new int[] { 1, 2 }, new int[] { 1, 2 } },
            //    new int[][] { new int[] { 2, 3 }, new int[] { 2, 3 } });

            //For example, when an array is passed like [19, 5, 42, 2, 77], the output should be 7.
            // [10, 343445353, 3453445, 3453545353453] should return 3453455.

            int[] numbers = { 5, 8, 12, 19, 22 };
            int[] numbers1 = { 8, 8, 8, 19, 22 };
            int[] numbers2 = { 5, 22 };
            int[] numbers3 = { 22 };
            int[] numbers4 = { };
            //(13, Kata.sumTwoSmallestNumbers(numbers));

            Console.WriteLine("13, " + sumTwoSmallestNumbers(numbers));
            Console.WriteLine("16, " + sumTwoSmallestNumbers(numbers1));
            Console.WriteLine("27, " + sumTwoSmallestNumbers(numbers2));
            Console.WriteLine("22, " + sumTwoSmallestNumbers(numbers3));
            Console.WriteLine("0, " + sumTwoSmallestNumbers(numbers4));

        }
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            if (numbers.Length < 2)
            { 
                if (numbers.Length == 0)
                {
                    return 0;
                }
                return numbers[0];
            }
            var numbersSort = new List<int>(numbers);
            int sum = 0;
            var maxNumberIndex = 0;
            var maxNumberValue = numbersSort[0];
            while (numbersSort.Count > 2)
            {
                for (int i = 0; i < numbersSort.Count; i++)
                {
                    if (numbersSort[i] > maxNumberValue)
                    {
                        maxNumberIndex = i;
                        maxNumberValue = numbersSort[i];
                    }
                }
                numbersSort.RemoveAt(maxNumberIndex);
                maxNumberIndex = 0;
                maxNumberValue = numbersSort[0];
            }
            foreach (var num in numbersSort)
            {
                sum += num;
            }
            return sum;
        }
        public static int[][] MatrixAddition(int[][] a, int[][] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    a[i][j] += b[i][j];
                }
            }
            return a;
        }
        public static int[] ArrayDiff(int[] a, int[] b) // TODO do not work, but why?
        {
            for (int second = 0; second < b.Length; second++)
            {
                for (int first = 0; first < a.Length; first++)
                {
                    if (a[first] == b[second])
                    {
                        for (int i = first; i < a.Length - 1; i++)
                        {
                            a[i] = a[i + 1];
                        }
                        Array.Resize(ref a, a.Length - 1);
                        first = 0;
                    }
                }
            }
            return a;
        }
        public static string AlphabetPosition(string text)
        {
            var letters = text.ToLower().ToCharArray();
            string result = "";
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] > 96 && letters[i] < 123)
                {
                    if (i == 0)
                    {
                        result += $"{letters[i] - 96}";
                    }
                    else
                    {
                        result += $" {letters[i] - 96}";
                    }
                }
            }
            return result;
        }
        public static int rowSumOddNumbers(int n)
        {
            int result = Convert.ToInt32((((n + 1.0) / 2 * n * 2) - n) * n);
            return result;
        }
        public static int Persistence(long n)
        {
            int persistence = 0;
            while (n > 9)
            {
                persistence++;
                int result = 1;
                while (n > 0)
                {
                    int m = (int)(n % 10);
                    result *= m;
                    n = n / 10;
                }
                n = result;
            }
            return persistence;
        }
        public static int MakeNegative(int number)
        {
            return number <= 0 ? number : -number;
        }
        public static bool Check(object[] a, object x)
        {
            foreach (var item in a)
            {
                if (item.Equals(x))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
