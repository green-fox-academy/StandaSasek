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
            foreach (var item in Sharpies)
            {
                if (item.InkAmountSharpie() > 0)
                {
                    numberOfSharpiesWithInk += 1;
                }
            }
            Console.WriteLine("There is {0} usable Sharpies in set.", numberOfSharpiesWithInk); // TODO add name of SharpieSet
        }
        public void RemoveTrash()
        {
            var numberOfSharpiesWithInk = Sharpies.Count;
            for (int i = 0; i < Sharpies.Count; i++)
            {
                if (Sharpies[i].InkAmountSharpie() == 0)
                {
                    Sharpies.Remove(Sharpies[i]);
                    numberOfSharpiesWithInk -= 1;
                }
            }
            Console.WriteLine("In set left only {0} usable Sharpies.", numberOfSharpiesWithInk); // TODO find why it counts +1
        }

    }
}
