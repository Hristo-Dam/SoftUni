using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolDB.Models
{
    public class Class
    {
        public Class()
        {
            IsDeleted = false;
        }

        [Key]
        public int Id { get; set; }

        public string Name {  get; set; }

        ICollection<Student> Students { get; set; } = new List<Student>();

        public bool IsDeleted { get; set; }
    }
}
