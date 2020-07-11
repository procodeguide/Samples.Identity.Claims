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
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        public IActionResult Claims()
        {
            return View();
        }
    }
}
