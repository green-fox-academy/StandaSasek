using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTBErrorReporter.Models.Entities
{
    public class Search
    {
        public string Manufacturer { get; set; }
        public string Reporter { get; set; }

        public Search()
        {
        }
        public Search(string manufacturer, string reporter)
        {
            Manufacturer = manufacturer;
            Reporter = reporter;
        }
        public Search(string reporter)
        {
            Reporter = reporter;
        }
    }
}
