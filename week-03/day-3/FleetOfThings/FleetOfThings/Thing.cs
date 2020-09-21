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
            return (completed ? "[x] " : "[ ] ") + name;
        }
    }
}