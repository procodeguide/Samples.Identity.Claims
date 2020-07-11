using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProCodeGuide.Sample.Blog.Helpers;
using ProCodeGuide.Sample.Blog.Models;

namespace ProCodeGuide.Sample.Blog.Controllers
{
    [Authorize]
    public class PostsController : Controller
    {
        private readonly ILogger<PostsController> _logger;

        public PostsController(ILogger<PostsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Post> posts = DataHelper.GetAllPosts();
            return View(posts);
        }

        [Authorize(Policy = "EmailID")]
        public IActionResult Details(string id)
        {
            Post post = DataHelper.GetAllPosts().Find(p => p.Id.Equals(id));
            return View(post);
        }
    }
}
