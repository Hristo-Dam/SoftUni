using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Data.Models
{
    public class Resource
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50), Unicode]
        public string Name { get; set; }

        public string Url { get; set; }

        public string ResurceType { get; set; }
    }
}
