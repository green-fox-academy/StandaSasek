using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class BlogPost
    {

        public string authorName;
        public string title;
        public string text;
        public string publicationDate;

        public BlogPost(string authorName, string title, string text, string publicationDate)
        {
            this.authorName = authorName;
            this.title = title;
            this.text = text;
            this.publicationDate = publicationDate;
        }
        public BlogPost()
        {
            authorName = "John Doe";
            title = "Lorem Ipsum";
            text = "Lorem ipsum dolor sit amet.";
            publicationDate = "1900.30.01.";
        }
        public void PrintBlogPost()
        {
            Console.WriteLine();
            Console.WriteLine("Blog post titled \"{0}\" written by {1} posted at {2}", title, authorName, publicationDate);
            Console.WriteLine(); 
            Console.Write("\u25A0 ".PadLeft(6) + text);
        }
    }
}
