using System.Collections.Generic;

namespace Printable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Todo> todos = new List<Todo>
            {
                { new Todo("Buy milk", "low", false) },
                { new Todo("Practice", "high", true) },
                { new Todo("Homework", "medium", false) }
        };
            foreach (var item in todos)
            {
                item.PrintAllFields();
            }
            List<Domino> dominoes = new List<Domino>
            {
                { new Domino(2, 5) },
                { new Domino(3, 3) },
                { new Domino(1, 7) }
            };
            foreach (var item in dominoes)
            {
                item.PrintAllFields();
            }

            var listOfItems = new List<IPrintable> // thanks Honzo
                {
                { new Todo("Buy milk", "low", false) },
                { new Domino(2, 5) },
                { new Domino(3, 3) },
                { new Todo("Practice", "high", true) },
                { new Todo("Homework", "medium", false) },
                { new Domino(1, 7) }
            };
            foreach (var item in listOfItems)
            {
                item.PrintAllFields();
            }
        }
    }
}
