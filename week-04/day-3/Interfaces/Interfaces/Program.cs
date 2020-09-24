using System;
using ZOO;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Helicopter copter = new Helicopter(4, 120, "Heli");

            copter.Intro();
            copter.TakeOff();
            copter.Fly();
            copter.Land();

            Bird sparrow = new Bird("Sparrow", 2, Gend.male, Feed.everything, "grey brown");

            sparrow.Intro();
            sparrow.TakeOff();
            sparrow.Fly();
            sparrow.Land();
        }
    }
}
