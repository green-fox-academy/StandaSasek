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
        public User(string name, string email, string password, List<Post> posts, List<Vote> votes)
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
