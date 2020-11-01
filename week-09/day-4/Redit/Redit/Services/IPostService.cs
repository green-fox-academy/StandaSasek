using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Redit.Models.Entities;

namespace Redit.Services
{
    public interface IPostService
    {
        public List<Post> ListAllPosts();
        public Post ReadPost(int id);
        public void Submit(Post post);
        public void UpdatePost(Post postToUpdate);
        public void Vote(long id, int value);
    }
}
