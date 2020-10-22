using System;

namespace DependencyInj
{
    class Program
    {
        static void Main(string[] args)
        {
            var main = new Main(new MyOtherDependency());
            main.DoWork();
        }
    }
}
