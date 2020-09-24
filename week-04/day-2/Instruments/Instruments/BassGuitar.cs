using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments
{
    class BassGuitar : StringedInstrument
    {
        public BassGuitar(int strings = 4)
        {
            Name = "Bass Guitar";
            numberOfStrings = strings;
        }
        public override string Sound()
        {
            return "duum-duum-duum";
        }
    }
}
