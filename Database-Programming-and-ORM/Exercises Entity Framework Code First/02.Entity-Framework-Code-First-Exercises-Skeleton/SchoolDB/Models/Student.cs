using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolDB.Models
{
    public class Student
    {
        public Student()
        {
            IsDeleted = false;
        }

        [Key]
        public int Id { get; set; }

        public string FisrtName { get; set; }

        public string LastName { get; set; }

        [ForeignKey(nameof(Class))]
        public int ClassId { get; set; }
        public Class Class { get; set; }

        public bool IsDeleted { get; set; }

    }
}
