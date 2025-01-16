using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumDatabase.Data.Models
{
    public class PostAwnser
    {
        [Key]
        public int Id { get; set; }

        public string AwnserContent { get; set; }

        [ForeignKey(nameof(Post))]
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
