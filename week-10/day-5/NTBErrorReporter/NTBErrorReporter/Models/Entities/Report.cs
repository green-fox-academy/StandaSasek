using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NTBErrorReporter.Models.Entities
{
    public class Report
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Reporter ReporterName { get; set; }
        public int ReporterId { get; set; }
        public string Manufacturer { get; set; }
        public string SerialNumber { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public Report(Reporter reporterName, int reporterId, string manufacturer, string serialNumber, string description)
        {
            ReporterName = reporterName;
            ReporterId = reporterId;
            Manufacturer = manufacturer;
            SerialNumber = serialNumber;
            Description = description;
            Date = DateTime.Now;
        }
        public Report()
        {
        }
    }
}
