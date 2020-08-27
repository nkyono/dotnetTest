using System;
namespace testApp
{
    public class RedditPost
    {
        public int id { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public int Upvotes { get; set; }

        public float UpvoteRatio { get; set; }

        public string URL { get; set; }

        public string Permalink { get; set; }

        public int Sub_id { get; set; }

    }
}
