using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NTBErrorReporter.Models.Entities;

namespace NTBErrorReporter.Models.ViewModels
{
    public class IndexViewModel
    {
        public List<Report> MyReports { get; set; }
        public Report MyReport { get; set; }
        public Reporter MyReporter { get; set; }
        public List<Reporter> MyReporters { get; set; }
        
        public IndexViewModel()
        {
        }
        public IndexViewModel(List<Report> myReports, Report myReport, Reporter myReporter, List<Reporter> myReporters)
        {
            MyReports = myReports;
            MyReport = myReport;
            MyReporter = myReporter;
            MyReporters = myReporters;
        }
        public IndexViewModel(List<Report> myReports, List<Reporter> myReporters)
        {
            MyReports = myReports;
            MyReporters = myReporters;
        }
    }
}
