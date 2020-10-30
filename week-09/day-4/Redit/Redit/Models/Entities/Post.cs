using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Redit.Models.Entities
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Text { get; set; }
        public string Link { get; set; }
        public List<Vote> Votes { get; set; }
        public User Author { get; set; }
        public int UserId { get; set; }
        public Post(DateTime created, string text, string link, List<Vote> votes, User author, int userId)
        {
            Created = created;
            Text = text;
            Link = link;
            Votes = votes;
            Author = author;
            UserId = userId;
        }
        public Post()
        {
        }
    }
}
