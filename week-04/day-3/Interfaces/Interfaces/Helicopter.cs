using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Helicopter : Vehicle, IFlyable
    {
        public Helicopter(int length, int speed, string name) : base (length, speed, name)
        {
        }
        public void Fly()
        {
            Console.WriteLine("iFly!");
        }

        public void Land()
        {
            Console.WriteLine("What a smooth landing.");
        }

        public void TakeOff()
        {
            Console.WriteLine("Just make the rotation faster and I can take off. But it takes lot of fuel.");
        }
        public void Intro()
        {
            Console.WriteLine("I am helicopter named {0}.", name);
        }
    }
}
