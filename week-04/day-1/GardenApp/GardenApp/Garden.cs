using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApp
{
    class Garden
    {
        public List<Plant> Plants { get; set; }

        public Garden()
        {
            Plants = new List<Plant>();
        }
        public void PlantToGarden(Plant plant)
        {
            Plants.Add(plant);
        }
        public void PlantsStatus()
        {
            foreach (var plant in Plants)
            {
                Console.WriteLine("The {0} {1}", plant, plant.NeedsWater());
            }
        }
        public void Watering(double water)
        {
            Console.WriteLine("Watering with {0}", water);
            var numberInNeed = 0;
            foreach (var plant in Plants)
            {
                if (plant.WaterLevel < plant.Thirsty)
                {
                    numberInNeed++;
                }
            }
            var waterPortion = water / numberInNeed;
            foreach (var plant in Plants)
            {
                if (plant.WaterLevel < plant.Thirsty)
                {
                    plant.WateringPlant(waterPortion);
                }
            }
        }
    }
}
