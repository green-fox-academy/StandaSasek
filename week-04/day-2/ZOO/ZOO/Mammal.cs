using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    class Mammal : Animal
    {
        protected string furColor;
        protected int tailLength;
        public Mammal(string inpName, int inpAge, Gend inpGender, Feed inpFood, string inpFurColor, int inpTailLength)
            : base(inpName, inpAge, inpGender, inpFood)
        {
            legs = 4;
            if (inpGender == Gend.female)
            {
                wayBorn = "my uterus";
            }
            else
            {
                wayBorn = "the womb of my lovely wife";
            }
            furColor = inpFurColor;
            tailLength = inpTailLength;
        }
        public override string Greet()
        {
            return greet;
        }
        public override string MoreInfo()
        {
            return $" You know what? I have got {legs} legs, nice {furColor} fur and {tailLength} cm long tail. Cool!";
        }
    }
}
