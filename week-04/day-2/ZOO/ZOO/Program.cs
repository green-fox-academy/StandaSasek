using System;

namespace ZOO
{
    class Zoo
    {
        static void Main(string[] args)
        {

            var reptile = new Reptile("Crocodile", 8, Gend.male, Feed.meat, true);
            var mammal = new Mammal("Koala", 15, Gend.female, Feed.vegies, "grey", 6 );
            var bird = new Bird("Parrot", 45, Gend.male, Feed.everything, "white");

            Console.WriteLine("Who want a baby?");
            Console.WriteLine(reptile.GetName() + reptile.Greet() + reptile.WantChild() + reptile.MoreInfo());
            Console.WriteLine(mammal.GetName() + mammal.Greet() + mammal.WantChild() + mammal.MoreInfo());
            Console.WriteLine(bird.GetName() + bird.Greet() + bird.WantChild() + bird.MoreInfo());


        }
    }
}
