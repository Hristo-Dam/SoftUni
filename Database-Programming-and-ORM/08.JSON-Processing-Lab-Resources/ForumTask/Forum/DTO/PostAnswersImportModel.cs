using System;
using System.Collections.Generic;
using System.Text;
using Forum.Models;

namespace Forum.DTO
{
    public class PostAnswersImportModel
    {
        public int Id { get; set; }
        public string AnswerContent { get; set; }
        public int PostId { get; set; }
    }
}
