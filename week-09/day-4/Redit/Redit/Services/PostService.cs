using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Redit.Database;
using Redit.Models.Entities;

namespace Redit.Services
{
    public class PostService : IPostService
    {
        private readonly ApplicationDbContext dbContext;

        public PostService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Post> ListAllPosts()
         {
             return dbContext.Posts.OrderByDescending(post => post.WorkVotes).Include(post => post.Author).Include(post => post.Votes).ToList();
         }
        public Post ReadPost(int id)
        {
            return dbContext.Posts.
                Include(ass => ass.Author).
                FirstOrDefault(t => t.Id.Equals(id));
        }
        public void Submit(Post post)
        {
            dbContext.Posts.Add(post);
            dbContext.SaveChanges();
        }
        public void UpdatePost(Post postToUpdate)
        {
            /*var dbPost = ReadPost(postToUpdate.Id);
            dbPost.Text = postToUpdate.Text;
            dbPost.Link = postToUpdate.Link;*/
            dbContext.Update(postToUpdate); // works itself well
            dbContext.SaveChanges();
        }
        public void Vote(long id, int value)
        {
            var postToUpdate = dbContext.Posts.FirstOrDefault(post => post.Id == id);
            postToUpdate.WorkVotes += value; // HACK rework after Login and User finished

            dbContext.Update(postToUpdate);
            dbContext.SaveChanges();
        }
    }
}
