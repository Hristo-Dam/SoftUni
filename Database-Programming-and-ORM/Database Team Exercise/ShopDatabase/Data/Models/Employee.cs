using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDatabase.Data.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string  Name { get; set; }

        public int Age { get; set; }

        public decimal Salary { get; set; }

        public bool IsWorking { get; set; }


        [ForeignKey(nameof(Shop))]
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
    }
}
