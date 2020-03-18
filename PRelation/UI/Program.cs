using Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            BlogDB dB = new BlogDB();
            dB.Database.EnsureDeleted();
            dB.Database.EnsureCreated();

            var blog = new Blog
            {
                Name = "V1",
                CreateDate = DateTime.Now,
            };

            dB.Blogs.Add(blog);
            dB.SaveChanges();


            var posts = new List<Post> {

            new Post{ BlogId=blog.Id,Body="V1Body1"},
             new Post{ BlogId=blog.Id,Body="V1Body2"},
              new Post{ BlogId=blog.Id,Body="V1Body3"},
            };

            dB.Posts.AddRange(posts);
            dB.SaveChanges();

            //dB.Remove(blog);
            //dB.SaveChanges();
            //dB.Posts.ToList();
            //dB.Remove(new Blog { Id = 1 });
            //dB.SaveChanges();

            Console.WriteLine("Hello World!");
        }
    }
}
