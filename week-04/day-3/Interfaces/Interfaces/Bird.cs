using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;

namespace ZOO
{
    class Bird : Animal, IFlyable
    {
        protected string featherColor;
        public Bird(string inpName, int inpAge, Gend inpGender, Feed inpFood, string inpFeatherColor)
            : base(inpName, inpAge, inpGender, inpFood)
        {
            featherColor = inpFeatherColor;
            wayBorn = "an egg";
            legs = 2;
        }

        public void Fly()
        {
            Console.WriteLine("I wave and fly!");
        }

        public void Intro()
        {
            Console.WriteLine("I am small bird named {0}.", name);

        }

        public override string Greet()
        {
            throw new NotImplementedException();
        }

        public void Land()
        {
            Console.WriteLine("I can land on a branch.");
        }

        public override string MoreInfo()
        {
            return $" By the way, my feather is {featherColor} and I can fly. Escapingish!";
        }

        public void TakeOff()
        {
            Console.WriteLine("A few waves and leave my perch. Almost no fuel added.");
        }
    }
}
