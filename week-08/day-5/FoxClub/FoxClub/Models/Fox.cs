using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class Fox
    {
        public string Name { get; set; }
        public List<string> Tricks { get; set; }
        public string Food { get; set; }
        public string Drink { get; set; }
        public Fox(List<string> tricks, string name = "Mr. Fox", string food = "pizza", string drink = "lemonade")
        {
            Name = name;
            Tricks = tricks;
            Food = food;
            Drink = drink;
        }
    }
}
