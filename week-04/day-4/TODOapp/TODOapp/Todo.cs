using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Todoapp
{
    class Todo
    {
        public string Task { get; set; }
        // TODO add priority sorting function
        // protected string priority; 
        public char Done { get; set; }

        public Todo(char done, string task)
        {
            Task = task;
            Done = done;
        }
        public void IfDone()
        {
            if (Done == 'n')
            {
                Done = 'd';
            }
            else
            {
                Done = 'n';
            }
        }
        public string IsDone()
        {
            return (Done == 'd' ? "[x] " : "[ ] ") + Task;
        }
     
    }
}
