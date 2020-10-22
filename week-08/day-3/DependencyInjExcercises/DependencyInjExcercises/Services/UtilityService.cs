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
            try
            {
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == email ? $"<p style=\"background-color: Green\">{email} is a valid email address\"</p>" : $"<p style=\"background-color: Red\">{email} is not a valid email address\"</p>";
            }
            catch
            {
                return $"<p style=\"background-color: Red\">{email} is not a valid email address\"</p>";
            }
        }
    }
}
