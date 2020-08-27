using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace testApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RedditPostsController : ControllerBase
    {
        public RedditPostsController()
        {
        }

        [HttpGet]
        public IEnumerable<RedditPost> Get()
        {
            using var context = new RedditDbContext();
            var redditDb = context.Reddit_Posts.ToArray();
            return redditDb;
        }
    }
}
