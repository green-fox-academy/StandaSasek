using System;

namespace GardenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Flower yellow = new Flower("yellow");
            Flower blue = new Flower("blue");
            Tree purple = new Tree("purple");
            Tree orange = new Tree("orange");

            Garden garden = new Garden();

            garden.PlantToGarden(yellow);
            garden.PlantToGarden(blue);
            garden.PlantToGarden(purple);
            garden.PlantToGarden(orange);

            garden.PlantsStatus();

            Console.WriteLine();
            garden.Watering(40);
            garden.PlantsStatus();

            Console.WriteLine();
            garden.Watering(70);
            garden.PlantsStatus();

        }
    }
}
