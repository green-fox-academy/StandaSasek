using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApiTraining.Models
{
    public class LogEntry
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string EndPoint { get; set; }
        public string Data { get; set; }

        public LogEntry()
        {
        }

        public LogEntry(DateTime createdAt, string endPoint, string data)
        {
            CreatedAt = createdAt;
            EndPoint = endPoint;
            Data = data;
        }
    }
}
