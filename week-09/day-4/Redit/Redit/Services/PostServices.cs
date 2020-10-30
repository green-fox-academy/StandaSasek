using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Redit.Database;
using Redit.Models.Entities;

namespace Redit.Services
{
    public class PostServices : IPostServices
    {
        private readonly ApplicationDbContext dbContext;

        public PostServices(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Post> ListAllPosts()
         {
             return dbContext.Posts.Include(post => post.Author).Include(post => post.Votes).ToList();
         }
        public void Submit(Post post)
        {
            dbContext.Posts.Add(post);
            dbContext.SaveChanges();
        }
        public void UpdatePost(Post postToUpdate)
        {
            dbContext.Update(postToUpdate);
            dbContext.SaveChanges();
        }
    }
}
