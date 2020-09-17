using System;

namespace FleetOfThings
{
    public class Thing
    {
        private string name;
        private bool completed;

        public Thing(string name)
        {
            this.name = name;
        }

        public void Complete()
        {
            this.completed = true;
        }
        public string NameWithCompleted()
        {
            if (this.completed)
            {
                return ("[x] " + this.name);
            }
            else
            {
                return ("[ ] " + this.name);
            }
        }
    }
}