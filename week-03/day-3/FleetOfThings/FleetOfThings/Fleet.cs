using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace FleetOfThings
{
    public class Fleet : IComparable<Things>
    {
        private List<Thing> Things;

        public Fleet()
        {
            Things = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            Things.Add(thing);
        }


        public void PrintFleet()
        {
            foreach (var thing in Things)
            {
                var index = this.Things.IndexOf(thing);
                Console.WriteLine((index + 1) + ". " + thing.NameWithCompleted()); // 1. [ ] Get milk
            }
        }
        public int CompareTo([AllowNull] Thing other)
        {
            return this is Completed  == other.Values[0] ?
                this.Values[1].CompareTo(other.Values[1]) :
                this.Values[0].CompareTo(other.Values[0]);
        }
    }
}