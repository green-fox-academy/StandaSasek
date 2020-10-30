using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Redit.Models.Entities;

namespace Redit.Models.ViewModels
{
    public class IndexViewModel
    {
        public List<Post> MyPosts { get; set; }
        public Post MyPost { get; set; }
        public List<User> MyUsers { get; set; }
        public User MyUser { get; set; }
        public List<Vote> MyVotes { get; set; }
        public Vote MyVote { get; set; }
        public IndexViewModel()
        {
        }
        public IndexViewModel(List<Post> myPosts, Post myPost, List<User> myUsers, User myUser, List<Vote> myVotes, Vote myVote)
        {
            MyPosts = myPosts;
            MyPost = myPost;
            MyUsers = myUsers;
            MyUser = myUser;
            MyVotes = myVotes;
            MyVote = myVote;
        }

        public IndexViewModel(List<Post> myPosts)
        {
            MyPosts = myPosts;
        }
    }
}
