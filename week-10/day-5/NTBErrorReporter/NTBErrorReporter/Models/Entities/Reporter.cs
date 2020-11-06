using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NTBErrorReporter.Models.Entities
{
    public class Reporter
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Report> Reports { get; set; }
     
        public Reporter(string name,  List<Report> reports)
        {
            Name = name;
            Reports = reports;
        }
        public Reporter()
        {
        }
    }
}
