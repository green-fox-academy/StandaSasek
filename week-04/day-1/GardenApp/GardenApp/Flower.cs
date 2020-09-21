using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApp
{
    class Flower : Plant
    {
        public Flower(string _color) : base(_color)
        {
            Absorbance = 0.75;
            Thirsty = 5;
        }
        public override string ToString()
        {
            return $"{Color} {GetType().Name}";
        }
    }
}
