using System;
using System.Collections.Generic;

namespace Domino
{
    public class Dominoes
    {
        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();
            // You have the list of Dominoes
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
            // Create a function to write the dominous to the console in the following format
            // eg: [2, 4], [4, 3], [3, 5] ...

            PrintDominoes(dominoes);
            dominoes.Sort();
            Console.WriteLine();
            PrintDominoes(dominoes);
            Console.WriteLine();
            GetRightOrderList(dominoes);
            Console.WriteLine();
            PrintDominoes(dominoes);

        }
        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }
        public static void GetRightOrderList(List<Domino> dominoes)
        {
            for (int i = 0; i < dominoes.Count; i++)
            {
                for (int j = 1; j < dominoes.Count; j++)
                {
                    if (dominoes[i].GetValues()[1] == dominoes[j].GetValues()[0])
                    {
                        dominoes.Insert(i + 1, dominoes[j]);
                        dominoes.RemoveAt(j + 1);
                    }
                }
            }
        }
        public static void PrintDominoes(List<Domino> dominoes)
        {
            for (int i = 0; i < dominoes.Count; i++)
            {
                Console.WriteLine(dominoes[i].GetValues()[0] + ", " + dominoes[i].GetValues()[1]);
            }
        }
    }
}
