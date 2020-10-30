using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Redit.Models.Entities;

namespace Redit.Services
{
    public interface IPostServices
    {
        public List<Post> ListAllPosts();
        public void Submit(Post post);
        public void UpdatePost(Post postToUpdate);
    }
}
