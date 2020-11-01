using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Redit.Models.Entities
{
    public class Vote
    {
        [Key]
        public int Id { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Post Post { get; set; }
        public int PostId { get; set; }

        public Vote(User user, int userId, Post post, int postId)
        {
            User = user;
            UserId = userId;
            Post = post;
            PostId = postId;
        }

        public Vote()
        {
        }
    }
}
