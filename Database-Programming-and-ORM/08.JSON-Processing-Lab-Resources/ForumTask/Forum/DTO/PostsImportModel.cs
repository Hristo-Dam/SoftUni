using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forum.DTO
{
    public class PostsImportModel
    {
        public int Id { get; set; }
        public string PostContent { get; set; }
        public int UserId { get; set; }
    }
}
