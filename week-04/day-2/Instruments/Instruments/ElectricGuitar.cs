using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments
{
    class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar(int strings = 6)
        {
            Name = "Electric Guitar";
            numberOfStrings = strings;
        }
        public override string Sound()
        {
            return "twangs";
        }
    }
}
