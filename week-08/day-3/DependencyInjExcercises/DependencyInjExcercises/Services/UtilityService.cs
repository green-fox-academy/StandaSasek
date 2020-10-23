using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjExcercises.Controllers
{
    public class UtilityService
    {
        private readonly List<string> colors;
        private readonly Random random;

        public UtilityService()
        {
            colors = new List<string>
        {
            "red",
            "blue",
            "lime",
            "orange",
            "magenta"
        };

            random = new Random();
        }

        public string RandomColor()
        {
            return colors[random.Next(colors.Count)];
        }
        public string ValidateEmail(string email)
        {
            if (email == null)
            {
                return $"<p>Enter an email address</p>";
            }
            try
            {
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == email ? $"<p style=\"background-color: Green\">{email} is a valid email address</p>" : $"<p style=\"background-color: Red\">{email} is not a valid email address\"</p>";
            }
            catch
            {
                return $"<p style=\"background-color: Red\">{email} is not a valid email address</p>"; 
            }
        }
        public string Caesar(string text, int number)
        {
            if (text == null)
            {
                return $"<p>Enter text for coding</p>";
            }
            if (number < 0)
            {
                number = number + 26;
            }
            string result = "";
            foreach (var character in text)
            {
                var offset = char.IsUpper(character) ? 'A' : 'a';
                result += (char)((character + number - offset) % 26 + offset);
            }
            return $"<p>Result of coding is: <br>{result}</p>";
        }
    }
}
