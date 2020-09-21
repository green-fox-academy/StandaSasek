using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApp
{
    class Plant
    {
        public string Color { get; protected set; }
        public double WaterLevel { get; protected set; }
        public double Absorbance { get; protected set; }
        public double Thirsty { get; protected set; }
        public Plant(string _color)
        {
            Color = _color;
            WaterLevel = 0;
        }
        public string NeedsWater()
        {
            return WaterLevel < Thirsty ? "needs water" : "doesnt need water";
        }
        public void WateringPlant(double water)
        {
            WaterLevel += water * Absorbance;
        }
    }
}
