using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApp
{
    class Tree : Plant
    {
        public Tree(string _color) : base(_color)
        {
            Absorbance = 0.4;
            Thirsty = 10;
        }
        public override string ToString()
        {
            return $"{Color} {GetType().Name}";
        }
    }
}
