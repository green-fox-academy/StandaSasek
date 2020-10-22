using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjExcercises
{
    public class BlueColor : IColor
    {
        public Printer MyPrinter { get; set; }
        public BlueColor(Printer printer)
        {
            MyPrinter = printer;
        }
        public void PrintColor()
        {
            MyPrinter.Log("It is blue in color...");
        }
    }
}
