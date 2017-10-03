using System;
using System.Linq;
using Spike.DataContexts;
using Spike.Models;

namespace Spike
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                var blogs = db.Blogs
                    .Where(b => b.Rating > 3)
                    .OrderBy(b => b.Url)
                    .ToList();
                Console.WriteLine(blogs.Select(b => b.Url));


                var blog = new Blog { Url = "http://www.example.com" };
                db.Blogs.Add(blog);
                db.SaveChanges();
            }
        }
    }
}
