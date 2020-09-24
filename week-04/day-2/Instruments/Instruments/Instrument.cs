using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments
{
    public abstract class Instrument
    {
        public string Name { get; protected set; }
        public abstract void Play();
    }
}
