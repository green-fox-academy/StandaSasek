using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Redit.Models.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Post> Posts { get; set; }
        public List<Vote> Votes { get; set; }
        public User(List<Post> posts, List<Vote> votes, string name = "Standa", string email = "standa@email.ne", string password = "Standa")
        {
            Name = name;
            Email = email;
            Password = password;
            Posts = posts;
            Votes = votes;
        }

        public User()
        {
        }
    }
}
