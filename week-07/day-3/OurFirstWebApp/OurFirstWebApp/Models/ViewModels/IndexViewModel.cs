using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OurFirstWebApp.Models;

namespace OurFirstWebApp.Models.ViewModels
{
    public class IndexViewModel
    {
        public Greeting MyGreeting { get; set; }
        public int Counter { get; set; }
        public IndexViewModel(Greeting myGreeting, int counter)
        {
            MyGreeting = myGreeting;
            Counter = counter;
        }
        // InvalidOperationException: The model item passed into the ViewDataDictionary is of type 
        //'OurFirstWebApp.Models.Greeting', but this ViewDataDictionary instance requires a model item 
        // of type 'OurFirstWebApp.Models.ViewModels.IndexViewModel'.
    }
}
