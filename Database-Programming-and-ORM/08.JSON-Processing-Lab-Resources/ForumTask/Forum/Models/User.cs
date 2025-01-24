using System.Collections.Generic;

namespace Forum.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public IList<Post> Posts { get; set; }
        public string PostContent { get; internal set; }
        public int UserId { get; internal set; }
    }
}
