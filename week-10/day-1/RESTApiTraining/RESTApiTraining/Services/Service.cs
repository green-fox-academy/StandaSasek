using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTApiTraining.Database;
using RESTApiTraining.Models;

namespace RESTApiTraining.Services
{
    public class Service
    {
        private readonly ApplicationDbContext dbContext;
        public Service(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CreateLog(LogEntry logEntry)
        {
            dbContext.LogEntries.Add(logEntry);
            dbContext.SaveChanges();
        }
        public List<LogEntry> ListAllLogEntries()
        {
            return dbContext.LogEntries.ToList();
        }
        public int CalculateUntil(string operation, Operation until)
        {
            var range = Enumerable.Range(1, until.Until.Value);
            int result;
            switch (operation)
            {
                case "sum":
                    result = range.Sum();
                    break;
                case "multiply":
                    result = range.Aggregate((n1, n2) => n1 * n2);
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
        }

        public string YodaTalk(List<string> words)
        {
            var result = new List<string>();
            var sentence = new List<int>();

            for (int i = 0; i < words.Count; i++)
            {
                if (char.IsUpper(words[i][0]))
                {
                    sentence.Add(i);
                    break;
                }
                if (words[i][words[i].Length - 1].Equals('.'))
                {
                    if (i > 0 && char.IsUpper(words[i][0]) && words[i - 1][words[i].Length - 1].Equals('.'))
                    {
                        result.Add(words[i]);
                    }
                    else
                    {
                        var firstWord = i - sentence.Count;
                        var length = sentence.Count - 1;
                        for (int word = firstWord; word < length; word++)
                        {
                            if (length - word > 2)
                            {
                                result.Add(words[word + 1]);
                                result.Add(words[word]);
                                word++;
                                break;
                            }
                            else if (length - word == 1)
                            {
                                result.Add(words[word]);
                            }
                            else
                            {
                                result.Add(words[word + 1]);
                                result.Add(words[word]);
                                word += 2;
                            }
                        }
                    }
                }
                sentence.Add(i);
            }
            return string.Join(' ', result);
        }
    }
}
