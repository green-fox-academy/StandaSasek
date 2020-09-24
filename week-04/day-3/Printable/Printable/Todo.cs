using System;
using System.Collections.Generic;
using System.Text;

namespace Printable
{
    class Todo : IPrintable
    {
        protected string task;
        protected string priority;
        protected bool done;

        public Todo(string task, string priority, bool done)
        {
            this.task = task;
            this.priority = priority;
            this.done = done;
        }
        public void PrintAllFields()
        {
            Console.WriteLine($"Task: {task} | Priority: {priority} | Done: {done}");
        }
    }
}
