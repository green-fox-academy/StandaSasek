using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInj
{
    static class MyDependencyFactory
    {
        public static IMyDependency GetMyDependencyObj()
        {
            return new MyDependency();
        }

    }
}
