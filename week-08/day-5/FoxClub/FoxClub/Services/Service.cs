using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClub.Models;

namespace FoxClub.Services
{
    public class Service
    {
        public List<Fox> Foxes { get; set; }
        public List<string> Tricks { get; set; }
        public Service(List<Fox> foxes)
        {
            Foxes = foxes;
        }
        public List<string> ListTricks()
        {
            List<string> listOfTricks = new List<string>(); // TODO fix tricks getting

            return listOfTricks;
        }
    }
}
