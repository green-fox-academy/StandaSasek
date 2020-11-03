using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Internal;

namespace RESTApiTraining.Services
{
    public class SithTalkService
    {
        public string YodaTalk(List<string> words)
        {
            var result = new List<string>();
            var sentences = new List<int>();
            
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i][words[i].Length - 1].Equals('.'))
                {
                    
                }
                if (char.IsUpper(words[i][0]))
                {

                }
            }
            return string.Join(' ', result);
        }
    }
}
