using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Todoapp
{
    class Todo
    {
        public string task;
        // TODO add priority sorting function
        // protected string priority; 
        protected bool done;

        public Todo(string task)
        {
            this.task = task;
        }
        
        public void Done()
        {
            if (!done)
            {
                done = true;
            }
            else
            {
                done = false;
            }
        }
        public string IsDone()
        {
            return (done ? "[x] " : "[ ] ") + task;
        }
     
    }
}
