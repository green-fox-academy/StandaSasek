using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorythms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //AreEqual("1a1b1c1d3e1f1g2h1i1j1k1l1m1n4o1p1q2r1s2t2u1v1w1x1y1z", 

            Console.WriteLine(StringLetterCount("The quick brown fox jumps over the lazy dog."));


            //AreEqual("2a1d5e1g1h4i1j2m3n3o3s6t1u2w2y", 

            Console.WriteLine(StringLetterCount("The time you enjoy wasting is not wasted time."));

            //AreEqual("", 

            Console.WriteLine(StringLetterCount("./4592#{}()"));

            /*string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
            string[] b = new string[] { "WEST" };

            Console.WriteLine(String.Join(", ", dirReduc(a)));


            string[] a1 = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
            string[] b1 = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
            Console.WriteLine(String.Join(", ", dirReduc(a1)));*/

        }
        public static string StringLetterCount(string str)
        {
            var letters = str.ToLower().Where(l => !Char.IsWhiteSpace(l) && Char.IsLetter(l)).GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count()).OrderBy(l => l.Key).Join("", l => $"{l.Value} + {l.Key.ToString()}));
            return string.Join("", letters.Select(x => (x.Value + x.Key.ToString())));
        }
        public static string[] dirReduc(String[] arr)
        {
            var direction = new List<string>(arr);
            var dict = new Dictionary<string, string>
            {
                {"NORTH", "SOUTH"},
                {"SOUTH", "NORTH"},
                {"WEST", "EAST"},
                {"EAST", "WEST"}
            };
            var theWay = false;
            while (!theWay)
            {
                for (int word = 0; word < direction.Count - 1; word++)
                {
                    string found;
                    if (dict.TryGetValue(direction[word], out found) && found == direction[word + 1])
                    {
                        direction.RemoveRange(word, 2);
                        if (word == arr.Length - 1)
                        {
                            break;
                        }
                        if (word != 0)
                        {
                        word = -1;
                        }
                    }
                }
                theWay = true;
            }
            return direction.ToArray();
        }
        public static int[] MoveZeroes(int[] arr)
        {
            var result = new List<int>();
            var zeros = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    result.Add(arr[i]);
                }
                else
                {
                    zeros.Add(arr[i]);
                }
            }
            return result.Concat(zeros).ToArray();
        }
        public static string Encode(string word)
        {
            var result = "";
            var vowels = new Dictionary<string, int>
            {
                { "a", 1 },
                { "e", 2 },
                { "i", 3 },
                { "o", 4 },
                { "u", 5 }
            };
            for (int i = 0; i < word.Length; i++)
            {
                if (vowels.ContainsKey(word[i].ToString()))
                {
                    result += vowels[word[i].ToString()];
                }
                else
                {
                    result += word[i].ToString();
                }
            }

            return result;
        }
        public static string Decode(string word)
        {
            var result = "";
            var vowels = new Dictionary<int, string>
            {
                { 1, "a" },
                { 2, "e" },
                { 3, "i" },
                { 4, "o" },
                { 5, "u" }
            };
            for (int i = 0; i < word.Length; i++)
            {
                if (vowels.ContainsKey(word[i]))
                {
                    result += vowels[word[i]];
                }
                else
                {
                    result += word[i].ToString();
                }
            }

            return result;
        }
        public static string GetMiddle(string s)
        {
            var result = "";
            if (s.Length < 3)
            {
                result = s;
                return result;
            }
            if (s.Length % 2 == 1)
            {
                result = s[s.Length / 2].ToString();
            }
            else
            {
                result = s[s.Length / 2].ToString() + s[(s.Length / 2) + 1].ToString();
            }
            return result;
        }
    }
}
