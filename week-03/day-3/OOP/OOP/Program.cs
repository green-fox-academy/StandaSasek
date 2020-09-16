using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            PostIt goodJob = new PostIt(ConsoleColor.Yellow, ConsoleColor.DarkBlue, "Good job!");

            goodJob.PrintPostIt();

            PostIt idea = new PostIt(ConsoleColor.DarkGreen, ConsoleColor.White, "Great idea!");

            idea.PrintPostIt();

            PostIt basicPostIt = new PostIt();
            basicPostIt.PrintPostIt();

            basicPostIt.Text = "Change it to be better";
            basicPostIt.PrintPostIt();






            List<string> tree = new List<string> { "Type", "Leaf color", "Age", "Sex" };
            List<string> apricot = new List<string> { "Ornamental", "Green", "5", "Partly self-pollinating" };
            List<string> apple = new List<string> { "Fruit", "Green", "5", "Cross-pollination" };
            List<string> cherry = new List<string> { "Fruit", "Dark green", "5", "Self-pollination" };
            List<string> nashi = new List<string> { "Fruit", "Dark green", "6", "Cross-pollination" };
            List<string> rowan = new List<string> { "Ornamental", "Light green", "7", "Self-pollination" };
        }
    }
}
