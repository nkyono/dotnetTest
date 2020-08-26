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
            return Enumerable.Range(1, 5).Select(index => new RedditPost
            {
                Id = 0,
                Title = "",
                Upvotes = 0,
                UpvoteRatio = (float)0.00,
                Url = "",
                Permalink = "",
                Date = "",
                SubId = 0
            })
            .ToArray();
        }
    }
}
