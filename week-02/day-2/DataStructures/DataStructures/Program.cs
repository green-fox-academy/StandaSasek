using System;
using System.Collections.Generic;
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
            /*string toBeReversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            Console.WriteLine(Reverse(toBeReversed));
            Console.ReadLine();*/

            // LIST INTRODUCTION 1
            /*var myList = new List<string>();
            myList.Add("William");
            myList.Add("John");
            myList.Add("Amanda");

            if (myList.Count == 0)
            {
                Console.WriteLine("empty");
            }
            Console.WriteLine("list not empty, enlisted {0} items", myList.Count);
            Console.WriteLine("third elelment of the list is {0}", myList[2]);
            Console.WriteLine();
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, myList[i]);
            }

            myList.RemoveAt(1);

            Console.WriteLine();
            for (int i = myList.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(myList[i]);
            }
            
            myList.Clear();

            Console.ReadLine();*/

            // MAP INTRODUCTION 1
            /*var myMap = new Dictionary<int, char> {};
            myMap.Add(97, 'a');
            myMap.Add(98, 'b');
            myMap.Add(99, 'c');
            myMap.Add(65, 'A');
            myMap.Add(66, 'B');
            myMap.Add(67, 'C');

            Console.WriteLine(myMap.Count);
            Console.WriteLine();
            foreach (var item in myMap)
            {
                Console.WriteLine(item.Key);
            }
            Console.WriteLine();
            foreach (var item in myMap)
            {
                Console.WriteLine(item.Value);
            }
            Console.WriteLine();

            myMap.Add(68, 'D');
            Console.WriteLine("In the map is {0} key-value pairs.", myMap.Count);
            Console.WriteLine();

            Console.WriteLine(myMap[99]);
            Console.WriteLine();

            myMap.Remove(97);

            Console.WriteLine(myMap.TryGetValue(100, out char value));

            myMap.Clear();

            Console.ReadLine();*/

            // LIST INTRODUCTION 2
            /* var myListA = new List<string>() { "Apple", "Avocado", "Blueberries", "Durian", "Lychee" };
             var myListB = new List<string>(myListA);

             foreach (var item in myListA)
             {
                 if (item == "Durian")
                 {
                     Console.WriteLine(true);
                 }
             }
             Console.WriteLine();

             myListB.Remove("Durian");
             myListA.Insert(4, "Kiwifruit");

             if (myListA.Count == myListB.Count)
             {
                 Console.WriteLine("Lists are the same size");
             } else
             {
                 Console.WriteLine("Lists aren't the same size");
             }
             Console.WriteLine("Avocado is on {0}. position in List A", myListA.IndexOf("Avocado"));
             Console.WriteLine("Durian is on {0}. position in List B", myListB.IndexOf("Durian"));

             myListA.AddRange(new string[] { "Passion Fruit", "Pomelo" });

             Console.WriteLine(myListA[2]);

             Console.WriteLine();
             Console.WriteLine("List A");
             foreach (var item in myListA)
             {
                 Console.WriteLine(item);
             }
             Console.WriteLine(); 
             Console.WriteLine("List B");
             foreach (var item in myListB)
             {
                 Console.WriteLine(item);
             }
             Console.ReadLine();*/

            // MAP INTRODUCTION 2
            /*var myMap = new Dictionary<string, string>
            { { "978-1-60309-452-8", "A Letter to Jo" },
                { "978-1-60309-459-7", "Lupus" },
                { "978-1-60309-444-3", "Red Panda and Moon Bear" },
                { "978-1-60309-461-0", "The Lab" }};

            foreach (KeyValuePair<string, string> kvp in myMap)
            {
                Console.WriteLine("{1} (ISBN: {0})", kvp.Key, kvp.Value);
            }

            myMap.Remove("978-1-60309-444-3");
            foreach (KeyValuePair<string, string> kvp in myMap)
            {
                if (kvp.Value == "The Lab")
                {
                    myMap.Remove(kvp.Key);
                }
            }
            Console.WriteLine();
            foreach (KeyValuePair<string, string> kvp in myMap)
            {
                Console.WriteLine("{1} (ISBN: {0})", kvp.Key, kvp.Value);
            }
            myMap.Add("978-1-60309-450-4", "They Called Us Enemy");
            myMap.Add("978-1-60309-453-5", "Why Did We Trust Him?");

            foreach (KeyValuePair<string, string> kvp in myMap)
            {
                if (kvp.Key == "478-0-61159-424-8")
                {
                    Console.WriteLine("Item with key: 478-0-61159-424-8 is in dict: " + true);
                }
            }
            foreach (KeyValuePair<string, string> kvp in myMap)
            {
                if (kvp.Key == "978-1-60309-453-5")
                {
                    Console.WriteLine("ISBN: {0} is associated to {1}", kvp.Key, kvp.Value);
                }
            }*/

            // PERSONAL FINANCE
            //            We are going to represent our expenses in a list containing integers.
            //Create a list with the following items.
            //500, 1000, 1250, 175, 800 and 120
            //Create an application which solves the following problems.
            //How much did we spend?
            //Which was our greatest expense?
            //Which was our cheapest spending?
            //What was the average amount of our spendings?

            /*List<int> spendings = new List<int> { 500, 1000, 1250, 175, 800, 120 };
            Spendings(spendings);*/

            // TELEPHONE BOOK
            // What is John K. Miller's phone number?
            //Whose phone number is 307 - 687 - 2982 ?
            //Do we know Chris E.Myers' phone number?
            /*var phoneBook = new Dictionary<string, string>
            { { "William A. Lathan", "405-709-1865" },
                { "John K. Miller", "402-247-8568" },
                { "Hortensia E. Foster", "606-481-6467" },
                { "Amanda D. Newland", "319-243-5613" },
                { "Brooke P. Askew", "307-687-2982" }};

            SearchPhoneBook(phoneBook, "John K. Miller");
            SearchPhoneBook(phoneBook, "307-687-2982");
            SearchPhoneBook(phoneBook, "Chris E.Myers");*/


        }
        public static void SearchPhoneBook(Dictionary<string, string> phoneBook, string question)
        {
            bool isKnownOwner = false;
            bool isKnownNumber = false;
            bool isKnown = true;
            string answer = "";
            foreach (KeyValuePair<string, string> phone in phoneBook)
            {
                if (phone.Key == question)
                {
                    isKnownOwner = true;
                    answer = phone.Value;
                }
                else if (phone.Value == question)
                {
                    isKnownNumber = true;
                    answer = phone.Key;
                }
                else if (phone.Value != question && phone.Key != question)
                {
                    isKnown = false;
                }
            }
            if (isKnownOwner)
            {
                Console.WriteLine($"You asked for owner of phone number {question}. Owner is {answer}");
            }
            else if (isKnownNumber)
            {
                Console.WriteLine($"You asked for phone number of {question}. It is {answer}");
            }
            else if (!isKnown)
            {
                Console.WriteLine($"We don't know phone number of " + question);
            }
        }

        public static void Spendings(List<int> amounts)
        {
            int sum = 0;
            List<int> sorted = new List<int>(amounts);
            for (int s = 0; s < sorted.Count; s++)
            {
                sum = sum + amounts[s];
                for (int i = s; i < sorted.Count; i++)
                {
                    if (sorted[s] > sorted[i])
                    {
                        int temp = sorted[s];
                        sorted[s] = sorted[i];
                        sorted[i] = temp;
                    }
                }
            }
            Console.WriteLine("How much did we spend? " + sum);
            Console.WriteLine("Which was our greatest expense? " + sorted[sorted.Count - 1]);
            Console.WriteLine("Which was our cheapest spending? " + sorted[0]);
            Console.WriteLine("What was the average amount of our spendings? " + (sum / sorted.Count));
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
