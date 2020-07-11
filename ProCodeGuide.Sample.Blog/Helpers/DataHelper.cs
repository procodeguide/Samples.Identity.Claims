using ProCodeGuide.Sample.Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.Blog.Helpers
{
    public static class DataHelper
    {
        public static List<Post> GetAllPosts()
        {
            List<Post> posts = new List<Post>();

            posts.Add(new Post
            {
                Id = "1",
                Title = "ASP.NET Core Caching",
                Description = "Implement ASP.NET Core Caching",
                CreatedOn = DateTime.Now.AddDays(-20).ToLongDateString()
            }) ;

            posts.Add(new Post
            {
                Id = "2",
                Title = "ASP.NET Core Microservices",
                Description = "Implement ASP.NET Core Microservices",
                CreatedOn = DateTime.Now.AddDays(-16).ToLongDateString()
            });

            posts.Add(new Post
            {
                Id = "3",
                Title = "ASP.NET Core Logging",
                Description = "Implement ASP.NET Core Logging",
                CreatedOn = DateTime.Now.AddDays(-12).ToLongDateString()
            });

            posts.Add(new Post
            {
                Id = "4",
                Title = "ASP.NET Core Minification",
                Description = "Implement ASP.NET Core Minification",
                CreatedOn = DateTime.Now.AddDays(-8).ToLongDateString()
            });

            posts.Add(new Post
            {
                Id = "5",
                Title = "ASP.NET Core Entity Framework",
                Description = "Implement ASP.NET Core Entity Framework",
                CreatedOn = DateTime.Now.AddDays(-2).ToLongDateString()
            });

            return posts;
        }
    }
}
