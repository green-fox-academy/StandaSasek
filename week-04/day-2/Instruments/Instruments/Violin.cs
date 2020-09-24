using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments
{
    class Violin : StringedInstrument
    {
        public Violin(int strings = 4)
        {
            Name = "Violin";
            numberOfStrings = strings;
        }
        public override string Sound()
        {
            return "screeches";
        }
    }
}
