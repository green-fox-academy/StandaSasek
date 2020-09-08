using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            // SIMPLE REPLACE
            /* string example = "In a dishwasher far far away";

             var example1 = example.Replace("dishwasher", "galaxy");

             // I would like to replace "dishwasher" with "galaxy" in this example, but it has a problem.
             // Please fix it for me!
             // Expected ouput: In a galaxy far far away

             Console.WriteLine(example1);*/

            // URL FIXER
            /*     string url = "https//www.reddit.com/r/nevertellmethebots";

                 // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
                 // Also, the URL is missing a crucial component, find out what it is and insert it too!
                 // Try to solve it more than once using different string functions!

                 // VAR 1 / not able to find other "not so much complicated" variant
                 *//*url = url.Replace("//", "://");
                 url = url.Replace("bots", "odds");*//*

                 Console.WriteLine(url);
                 Console.ReadLine();*/

            // TAKES LONGER
            /* string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";

             // When saving this quote a disk error has occured. Please fix it.
             // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
             // Using pieces of the quote variable (instead of just redefining the string)

             var words = quote.Split(' ');
             var wordsList = words.ToList();
             var word01 = "It";
             var subSentence = "always takes longer than";

            // StringBuilder builder = new StringBuilder("always takes longer than");

             for (int i = 0; i < wordsList.Count; i++)
             {
                 if (wordsList[i] == word01)
                 {
                     i++;
                     wordsList.Insert(i, subSentence);
                 }
             }
             quote = string.Join(' ', wordsList);
             Console.WriteLine(quote);*/

            // TO DO PRINT
            /*string todoText = " - Buy milk\n";
            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indentation

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            var str01 = "My todo:\n";
            var str02 = " - Download games\n";
            var str03 = " - Diablo";
            todoText = str01 + todoText + str02 + "    " + str03;
            Console.WriteLine(todoText);*/

            // REVERSE
            string toBeReversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            Console.WriteLine(Reverse(toBeReversed));
            Console.ReadLine();
        }

        public static string Reverse(string rev01)
        {
            var reversed = string.Empty;
            for (int i = rev01.Length - 1; i >= 0; i--)
            {
                reversed = reversed + rev01[i];
            }
            return reversed;
        }
    }
}
