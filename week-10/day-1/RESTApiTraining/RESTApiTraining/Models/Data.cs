using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApiTraining.Models
{
    public class Data
    {
        public int Recieved { get; set; }
        public int Result { get; set; }
        
        public Data(int recieved, int result)
        {
            Recieved = recieved;
            Result = result;
        }
    }
}
