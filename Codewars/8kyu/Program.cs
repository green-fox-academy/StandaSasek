using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

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

            /*Console.WriteLine("13, " + sumTwoSmallestNumbers(numbers));
            Console.WriteLine("16, " + sumTwoSmallestNumbers(numbers1));
            Console.WriteLine("27, " + sumTwoSmallestNumbers(numbers2));
            Console.WriteLine("22, " + sumTwoSmallestNumbers(numbers3));
            Console.WriteLine("0, " + sumTwoSmallestNumbers(numbers4));*/

            /*Console.WriteLine("15, " + Repeats(new List<int> { 4, 5, 7, 5, 4, 8 }));
            Console.WriteLine("19, " + Repeats(new List<int> { 9, 10, 19, 13, 19, 13 }));
            Console.WriteLine("12, " + Repeats(new List<int> { 16, 0, 11, 4, 8, 16, 0, 11 }));
            Console.WriteLine("22, " + Repeats(new List<int> { 5, 17, 18, 11, 13, 18, 11, 13 }));
            Console.WriteLine("24, " + Repeats(new List<int> { 5, 10, 19, 13, 10, 13 }));*/

            /*Console.WriteLine("0, " + Solve(new int[] { }));
            Console.WriteLine("7, " + Solve(new int[] { 1, 2, 3, 4 }));
            Console.WriteLine("13, " + Solve(new int[] { 1, 2, 3, 4, 5, 6 }));
            Console.WriteLine("47, " + Solve(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }));*/

            /*var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            foreach (var item in arr)
            {
                Console.WriteLine(IsPrime(item));
            }*/

            /* Console.WriteLine("I am not impressed by your performance." + Quote("george saint pierre"));
             Console.WriteLine("I'd like to take this chance to apologize.. To absolutely NOBODY!" + Quote("conor mcgregor"));
             Console.WriteLine("I am not impressed by your performance." + Quote("George Saint Pierre"));
             Console.WriteLine("I'd like to take this chance to apologize.. To absolutely NOBODY!" + Quote("Conor McGregor"));*/

            // To be a senior, a member must be at least 55 years old and have a handicap greater than 7.
            // In this croquet club, handicaps range from -2 to + 26; the better the player the lower the handicap.
            /*Console.WriteLine(new[] { "Open", "Senior", "Open", "Senior" } + ", " + OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } }));
            Console.WriteLine(new[] { "Open", "Open", "Open", "Open" } + ", " + OpenOrSenior(new[] { new[] { 3, 12 }, new[] { 55, 1 }, new[] { 91, -2 }, new[] { 54, 23 } }));
            Console.WriteLine(new[] { "Senior", "Open", "Open", "Open" } + ", " + OpenOrSenior(new[] { new[] { 59, 12 }, new[] { 45, 21 }, new[] { -12, -2 } }));*/

            /*Console.WriteLine(String.Join(", ", ArrayDiff(new int[] { 1, 2 }, new int[] { 1 })));
            Console.WriteLine(String.Join(", ", ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 })));
            Console.WriteLine(String.Join(", ", ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 2 })));
            Console.WriteLine(String.Join(", ", ArrayDiff(new int[] { 1, 2, 2 }, new int[] { })));
            Console.WriteLine(String.Join(", ", ArrayDiff(new int[] { }, new int[] { 1, 2 })));*/

            string s = "aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
            Console.WriteLine("3/56 ," + PrinterError(s));
        }
        public static string PrinterError(String s)
        {
            int errors = 0;
            foreach (var item in s)
            {
                if (item > 109)
                {
                    errors++;
                }
            }
            return $"{errors}/{s.Length}";
        }
        public static int[] ArrayDiff(int[] a, int[] b) // TODO does not work 
        {
            List<int> result = new List<int>();
            foreach (var number in a)
            {
                result.Add(number);
            }
            for (int second = 0; second < b.Length; second++)
            {
                for (int first = 0; first < result.Count; first++)
                {
                    if (result[first] == b[second])
                    {
                        result.RemoveAt(first);
                        first = 0;
                    }
                }
            }
            return result.ToArray();
        }
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            var result = new List<string>();
            foreach (var item in data)
            {
                if (item[0] >= 55 && item[1] > 7)
                {
                    result.Add("Senior");
                }
                else
                {
                    result.Add("Open");
                }
            }
            return result;
        }
        public static string Quote(string fighter)
        {
            if (fighter.ToLower() == "conor mcgregor")
            {
                return "I'd like to take this chance to apologize.. To absolutely NOBODY!";
            }
            else
            {
                return "I am not impressed by your performance.";
            }
        }
        public static bool IsPrime(int n)
        {
            if (n < 2 || n > 2 && n % 2 == 0)
            {
                return false;
            }
            if (n == 2)
            {
                return true;
            }
            for (int i = 3; i * i <= n; i = i + 2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        public static int Solve(int[] arr)
        {
            int result = 0;
            if (arr.Length < 3)
            {
                return 0;
            }
            List<int> primes = new List<int>() { 2 };
            for (int i = 2; i < arr.Length; i++)
            {
                bool prime = true;
                foreach (var number in primes)
                {
                    if (i % number == 0)
                    {
                        prime = false;
                    }
                }
                if (prime)
                {
                    primes.Add(i);
                }
            }
            foreach (var prime in primes)
            {
                result += arr[prime];
            }
            return result;
        }
        public static int Repeats(List<int> source)
        {
            while (source.Count > 2)
            {
                for (int i = 0; i < source.Count; i++)
                {
                    int a = source[i];
                    for (int j = 0; j < source.Count; j++)
                    {
                        if (i != j && a == source[j])
                        {
                            source.RemoveAt(i);
                            source.Remove(a);
                        }
                    }
                }
            }
            return source[0] + source[1];
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
