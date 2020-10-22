using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjExcercises
{
    public class GreenColor : IColor
    {
        public GreenColor()
        {
        }
        public void PrintColor()
        {
            Console.WriteLine("It is green in color...");
        }
    }
}
