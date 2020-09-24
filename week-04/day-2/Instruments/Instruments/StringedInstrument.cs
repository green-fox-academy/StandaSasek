using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments
{
    public abstract class StringedInstrument : Instrument
    {
        public int numberOfStrings;

        public override void Play()
        {
            Console.WriteLine($"{this.Name}, a {this.numberOfStrings}-stringed instrument that {this.Sound()}") ;
        }
        public abstract string Sound();
    }
}
