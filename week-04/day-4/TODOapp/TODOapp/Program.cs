using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Todoapp
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathFile = "todos.txt";

            if (args.Length == 0)
            {
                Usage();
            }
            else if (args[0].Equals("-l"))
            {
                ListAllTodos(GetTodos(pathFile));
            }
            else if (args[0].Equals("-a"))
            {
                if (args.Length >= 2)
                {
                    Todo newTodo = new Todo(args[1]);
                    AddToFile(newTodo, GetTodos(pathFile), pathFile);
                }
                else
                {
                    Console.WriteLine("Unable to add: no task provided");
                }
            }
            else if (args[0].Equals("-r"))
            {
                if (args.Length >= 2)
                {
                    bool input = Int32.TryParse(args[1], out int index);
                    if (input)
                    {
                        RemoveFromFile(index, GetTodos(pathFile), pathFile);
                    }
                    else
                    {
                        Console.WriteLine("Unable to remove: index is not a number");
                    }
                }
                else if (args.Length == 1)
                {
                    Console.WriteLine("Unable to remove: no index provided");
                }
            }
            else
            {
                Console.WriteLine("Unsupported argument");
            }

            /*ListAllTodos(GetTodos(pathFile)); 
            Todo pokus = new Todo("pokus new todo");
            Console.WriteLine(pokus.task);*/

        }
        public static void ListAllTodos(Dictionary<int, string> todosList)
        {
            Console.WriteLine();
            foreach (var line in todosList)
            {
                Console.WriteLine($"{line.Key} - {line.Value}");
            }
        }
        public static Dictionary<int, Todo> GetTodos(string pathFile)
        {
            var todosList = new Dictionary<int, Todo>();
            if (File.Exists(pathFile))
            {
                string[] lines = File.ReadAllLines(pathFile);
                if (lines.Length == 0)
                {
                    Console.WriteLine("No todos for today! :)");
                }
                else
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        var task = "";
                        for (int j = 1; j < lines[i].Length; i++)
                        {
                            task += lines[j];
                        }
                        Todo todo = new Todo(lines[i][0], task);
                        todosList.Add(i + 1, todo);
                    }
                }
            }
            else
            {
                Console.WriteLine("Unable to read file.");
            }
            return todosList;
        }
        public static void SaveTodos(string pathFile, Dictionary<int, Todo> todosList)
        {
            if (File.Exists(pathFile))
            {
                using (StreamWriter sw = new StreamWriter(pathFile))
                {
                    foreach (var todo in todosList)
                    {
                        sw.WriteLine(todo.Done.ToString() + todo.Task);
                    }
                }
            }
            else
            {
                Console.WriteLine("Unable to read file.");
            }
        }
        public static void AddToFile(Todo newTodo, Dictionary<int, string> todosList, string pathFile)
        {
            todosList.Add(todosList.Count + 1, newTodo.task);
            SaveTodos(pathFile, todosList);
        }
        /*public static void CheckTask(int index, Dictionary<int, string> todosList, string pathFile)
        {
            todosList.Add(todosList.Count + 1, newTodo.task);
            SaveTodos(pathFile, todosList);
        }*/
        public static void RemoveFromFile(int index, Dictionary<int, string> todosList, string pathFile)
        {
            var removed = todosList.Remove(index);
            if (!removed)
            {
                Console.WriteLine();
                Console.WriteLine("Unable to remove: index is out of bound");
            }
            SaveTodos(pathFile, todosList);
        }
        public static void Usage()
        {
            Console.WriteLine("\nCommand Line Todo application\n" +
                "=============================\n" +
                "Command line arguments:\n" +
                "    -l                     Lists all the tasks\n" +
                "    -a \"task to add\"       Adds a new task\n" +
                "    -r NUM                 Removes task number NUM\n" +
                "    -c NUM                 Completes task number NUM");
        }
    }
}
