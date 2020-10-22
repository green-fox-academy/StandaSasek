using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInj
{
    public class MyDependency : IMyDependency
    {
        public double Calculate()
        {
            var result = 5 * 5 / 3;
            return result;
        }
    }
    public class MyOtherDependency : IMyDependency
    {
        public double Calculate()
        {
            return 50 + 2.3;
        }
    }
}
