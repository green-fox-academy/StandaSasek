using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTBErrorReporter.Models.Entities
{
    public class SecretWord
    {
        public SecretWord()
        {
        }

        public SecretWord(string secret)
        {
            Secret = secret;
        }

        public string Secret { get; set; }
    }
}
