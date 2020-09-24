using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TODOapp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Usage();
            }


            foreach (var item in todos)
            {
                item.PrintAllFields();
            }
        }
        public void List()
        {
            var todos = new List<Todo>();
            using (var sr = new StreamReader("todos.txt"))
            {
                var line = "";
                while (line != null)
                {
                    line = sr.ReadLine();
                    allLines.Add(line);
                }
                var text = sr.ReadLine()
        }

        }
        public void Add()
        {
            using (var sw = new StreamWriter("todos.txt"))
            {
                sw.Write(todo);
            }

        }
        public static void Usage()
        {
            Console.WriteLine("\nCommand Line Todo application\n" +
                "=============================\n" +
                "Command line arguments:\n" +
                "    -l   Lists all the tasks\n" +
                "    -a   Adds a new task\n" +
                "    -r   Removes an task\n" +
                "    -c   Completes an task");
        }
    }
}
