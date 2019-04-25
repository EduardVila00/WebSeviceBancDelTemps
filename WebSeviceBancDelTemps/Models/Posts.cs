using System.Collections.Generic;
using System.Web.Mvc;

namespace WebSeviceBancDelTemps.Models
{
    public class Posts
    {
        public List<Post> posts { get; set; }

        public Posts(List<Post> posts)
        {
            this.posts = posts;
        }
    }
}