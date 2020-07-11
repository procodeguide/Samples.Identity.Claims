using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.Blog.Models
{
    public class Post
    {
        public string Id { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public string CreatedOn { get; set; }
    }
}
