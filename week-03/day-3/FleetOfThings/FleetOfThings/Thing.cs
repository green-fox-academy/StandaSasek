using System;

namespace FleetOfThings
{
    public class Thing
    {
        private string name;
        public bool Completed { get; set; }

        public Thing(string name)
        {
            this.name = name;
            Completed = false;
        }

        public void Complete()
        {
            Completed = true;
        }
        public string NameWithCompleted()
        {
            return (Completed ? "[x] " : "[ ] ") + name;
        }
    }
}