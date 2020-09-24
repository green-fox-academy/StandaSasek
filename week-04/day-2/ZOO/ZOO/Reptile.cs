using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    class Reptile : Animal
    {
        protected bool haveLegs;
        public Reptile(string inpName, int inpAge, Gend inpGender, Feed inpFood, bool inpHaveLegs)
            : base(inpName, inpAge, inpGender, inpFood)
        {
            wayBorn = "an egg";
            haveLegs = inpHaveLegs;
            if (haveLegs)
            {
                legs = 4;

            }
        }
        public override string Greet()
        {
            return greet;
        }
        public override string MoreInfo()
        {
            if (haveLegs)
            {
                return $" Interesting facts about me? I am a reptile with {legs} legs. Something extra, yeah!";
            }
            return $" Interesting facts about me? I have no legs or wings, but still can move. Wonderful!";
        }
    }
}
