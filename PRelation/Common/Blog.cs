using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class Blog
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreateDate { get; set; }

        public List<Post> Posts { get; set; }
    }


    public class Post
    {

        public int Id { get; set; }

        public string Body { get; set; }

        public int? BlogId { get; set; }

        //public string BlogName { get; set; }


    }


    public class BlogDB : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Post> Posts { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocaldb; Initial Catalog=DBRelation;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Blog>().HasMany(c => c.Posts).WithOne().OnDelete(DeleteBehavior.Cascade);
            //modelBuilder.Entity<Blog>().HasMany(c => c.Posts).WithOne().HasPrincipalKey(c=>c.Name);
        }
    }
}
