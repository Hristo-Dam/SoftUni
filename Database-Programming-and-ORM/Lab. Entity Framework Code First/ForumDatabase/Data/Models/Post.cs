using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumDatabase.Data.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        public string PostContent { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<PostAwnser> PostAwnsers { get; set; } = new List<PostAwnser>();
    }
}
