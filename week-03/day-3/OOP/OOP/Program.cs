﻿using System;
using System.Collections.Generic;
using System.Linq;
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

            /*Animal fox = new Animal("Fox");
            Console.WriteLine("Animal {0} feels hunger of {1} and thirst of {2}", fox.AnimalName, fox.Hunger, fox.Thirst);

            for (int i = 0; i < 25; i++)
            {
                fox.Drink();
                //fox.Eat();
            }
            Console.WriteLine("Animal {0} feels hunger of {1} and thirst of {2}", fox.AnimalName, fox.Hunger, fox.Thirst);
            for (int i = 0; i < 25; i++)
            {
                fox.Drink();
                fox.Eat();
            }
            Console.WriteLine("Animal {0} feels hunger of {1} and thirst of {2}", fox.AnimalName, fox.Hunger, fox.Thirst);
            for (int i = 0; i < 25; i++)
            {
                // fox.Drink();
                fox.Eat();
            }
            Console.WriteLine("Animal {0} feels hunger of {1} and thirst of {2}", fox.AnimalName, fox.Hunger, fox.Thirst);
            for (int i = 0; i < 60; i++)
            {
                fox.Play();
            }

            Console.WriteLine("Animal {0} feels hunger of {1} and thirst of {2}", fox.AnimalName, fox.Hunger, fox.Thirst);*/



            /*Counter pocitadlo = new Counter();
            Console.WriteLine(pocitadlo.Counted);

            for (int i = 0; i < 40; i++)
            {
                pocitadlo.Add();
            }

            Console.WriteLine(pocitadlo.Counted);

            pocitadlo.Reset();

            Console.WriteLine(pocitadlo.Counted);

            for (int i = 0; i < 123; i++)
            {
                pocitadlo.Add();
            }

            Console.WriteLine(pocitadlo.Counted);*/

            /*List<Pokemon> pokemonOfAsh = InitializePokemon();

            // Every pokemon has a name and a type.
            // Certain types are effective against others, e.g. water is effective against fire.

            // Ash has a few pokemon.
            // A wild pokemon appeared!

            Pokemon wildPokemon = new Pokemon("Oddish", "leaf", "water");

            // Which pokemon should Ash use?

            var theRightPokemon = "";
            foreach (var pokemon in pokemonOfAsh)
            {
                if (pokemon.IsEffectiveAgainst(wildPokemon, pokemon))
                {
                    theRightPokemon = pokemon.Name;
                }
            }

            Console.Write("I choose you, " + theRightPokemon);*/

            // Sharpie Set
            /*Reuse your Sharpie class
            Create SharpieSet class
            it contains a list of Sharpie
            Add method CountUsable() -> sharpie is usable if it has ink in it
            Add method RemoveTrash() -> removes all unusable sharpies*/

            Sharpie green = new Sharpie("Green", 50);
            Sharpie red = new Sharpie("Red", 50);
            Sharpie blue = new Sharpie("Blue", 50);
            Sharpie yellow = new Sharpie("Yellow", 10);
            Sharpie black = new Sharpie("Black", 40);
            SharpieSet penal = new SharpieSet();

            penal.AddToSet(green);
            penal.AddToSet(red);
            penal.AddToSet(blue);
            penal.AddToSet(yellow);
            penal.AddToSet(black);
            
            penal.CountUsable();

            for (int i = 0; i < 3; i++)
            {
                green.Use();
                red.Use();
                blue.Use();
                yellow.Use();
                black.Use();
            }
            penal.CountUsable();
           
            Console.WriteLine();

            penal.RemoveTrash();

            Console.WriteLine();
            penal.CountUsable();
            penal.RemoveTrash();


            /* List<string> tree = new List<string> { "Type", "Leaf color", "Age", "Sex" };
             List<string> apricot = new List<string> { "Ornamental", "Green", "5", "Partly self-pollinating" };
             List<string> apple = new List<string> { "Fruit", "Green", "5", "Cross-pollination" };
             List<string> cherry = new List<string> { "Fruit", "Dark green", "5", "Self-pollination" };
             List<string> nashi = new List<string> { "Fruit", "Dark green", "6", "Cross-pollination" };
             List<string> rowan = new List<string> { "Ornamental", "Light green", "7", "Self-pollination" };*/
        }

        /*private static List<Pokemon> InitializePokemon()
        {
            return new List<Pokemon>
            {
                new Pokemon("Balbasaur", "leaf", "water"),
                new Pokemon("Pikatchu", "electric", "water"),
                new Pokemon("Charizard", "fire", "leaf"),
                new Pokemon("Balbasaur", "water", "fire"),
                new Pokemon("Kingler", "water", "fire")
            };

        }*/
    }
}
