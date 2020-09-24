using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    class Bird : Animal
    {
        protected string featherColor;
        public Bird(string inpName, int inpAge, Gend inpGender, Feed inpFood, string inpFeatherColor)
            : base(inpName, inpAge, inpGender, inpFood)
        {
            featherColor = inpFeatherColor;
            wayBorn = "an egg";
            legs = 2;
        }
        public override string Greet()
        {
            return greet;
        }
        public override string MoreInfo()
        {
            return $" By the way, my feather is {featherColor} and I can fly. Escapingish!";
        }
    }
}
