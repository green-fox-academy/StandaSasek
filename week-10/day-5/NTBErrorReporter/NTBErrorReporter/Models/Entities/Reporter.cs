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
        public enum ReporterName
        {
            Pepa,
            Jack,
            Gertruda,
            Olive,
            Sean
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ReportId { get; set; }
        public List<Report> Reports { get; set; }
     
        public Reporter(string name, int reportId, List<Report> reports)
        {
            Name = name;
            ReportId = reportId;
            Reports = reports;
        }
        public Reporter()
        {
        }
    }
}
