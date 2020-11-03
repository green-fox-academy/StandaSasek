using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApiTraining.Models
{
    public class Arrays
    {
        public string What { get; set; }
        public List<int> Numbers { get; set; }

        public Arrays(string what, List<int> numbers)
        {
            What = what;
            Numbers = numbers;
        }
        public Arrays()
        {
        }
    }
}
