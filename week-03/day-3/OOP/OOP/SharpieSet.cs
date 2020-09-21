using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class SharpieSet
    {
        public List<Sharpie> Sharpies { get; set; }

        public SharpieSet()
        {
            Sharpies = new List<Sharpie>();
        }
        public void AddToSet(Sharpie sharpie)
        {
            Sharpies.Add(sharpie);
        }
        public void CountUsable()
        {
            var numberOfSharpiesWithInk = 0;
            for (int i = 0; i < Sharpies.Count; i++)
            {
                if (Sharpies[i].InkAmountSharpie() > 0)
                {
                    numberOfSharpiesWithInk += 1;
                }
            }
            Console.WriteLine("There is {0} usable Sharpies in set.", numberOfSharpiesWithInk); // TODO add name of SharpieSet
        }
        public void RemoveTrash()
        {
            // var numberOfSharpiesWithInk = 1; // TODO find out why it counts -1 - if I set 0 as in CountUsable. When CountUsable is 
            foreach (var item in Sharpies)
            {
                if (item.InkAmountSharpie() <= 0)
                {
                    Sharpies.Remove(item);
                }
            }
            Console.WriteLine("In set left only {0} usable Sharpies.", Sharpies.Count); 
        }

    }
}
