using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInj
{
    class Main
    {
        private IMyDependency MyObj { get; set; }

        public Main(IMyDependency myObj)
        {
            MyObj = myObj;
        }
        public void DoWork()
        {
            var result = MyObj.Calculate();
            Console.WriteLine($"The result is {result}");
        }
    }
}
