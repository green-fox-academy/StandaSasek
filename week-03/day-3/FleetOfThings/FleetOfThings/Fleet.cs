using System;
using System.Collections.Generic;

namespace FleetOfThings
{
    public class Fleet
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
    }
}