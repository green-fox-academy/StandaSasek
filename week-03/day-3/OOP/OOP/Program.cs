using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            /*PostIt goodJob = new PostIt(ConsoleColor.Yellow, ConsoleColor.DarkBlue, "Good job!");

            goodJob.PrintPostIt();

            PostIt idea = new PostIt(ConsoleColor.DarkGreen, ConsoleColor.White, "Great idea!");

            idea.PrintPostIt();

            PostIt basicPostIt = new PostIt();
            basicPostIt.PrintPostIt();

            basicPostIt.Text = "Change it to be better";
            basicPostIt.PrintPostIt();*/

            /*BlogPost myDefaultPost = new BlogPost();

            myDefaultPost.PrintBlogPost();

            BlogPost waitButWhy = new BlogPost("Tim Urban", "Wait but why", "A popular long-form, stick-figure-illustrated blog about almost everything.", "2010.10.10.");

            waitButWhy.PrintBlogPost();

            BlogPost onEngineer = new BlogPost();

            onEngineer.PrintBlogPost();

            onEngineer.authorName = "William Turton";
            onEngineer.title = "One Engineer Is Trying to Get IBM to Reckon With Trump";
            onEngineer.text = 
                "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center \n" +
                "of attention. When I asked to take his picture outside one of IBM’s New York City \n" +
                "offices, he told me that he wasn’t really into the whole organizer profile thing.";
            onEngineer.publicationDate = "2017.03.28.";

            onEngineer.PrintBlogPost();*/





            Console.ReadLine();


            List<string> tree = new List<string> { "Type", "Leaf color", "Age", "Sex" };
            List<string> apricot = new List<string> { "Ornamental", "Green", "5", "Partly self-pollinating" };
            List<string> apple = new List<string> { "Fruit", "Green", "5", "Cross-pollination" };
            List<string> cherry = new List<string> { "Fruit", "Dark green", "5", "Self-pollination" };
            List<string> nashi = new List<string> { "Fruit", "Dark green", "6", "Cross-pollination" };
            List<string> rowan = new List<string> { "Ornamental", "Light green", "7", "Self-pollination" };
        }
    }
}
