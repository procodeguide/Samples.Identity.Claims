using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ProCodeGuide.Sample.Blog.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the SampleAppUser class
    public class SampleAppUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
