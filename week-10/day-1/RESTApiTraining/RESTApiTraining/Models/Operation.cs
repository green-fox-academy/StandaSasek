using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApiTraining.Models
{
    public class Operation
    {
        public int? Until { get; set; }
        
        public Operation()
        {
        }
        public Operation(int until)
        {
            Until = until;
        }
    }
}
