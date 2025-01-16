using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ShopDatabase.Data.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public bool IsRegular { get; set; }

        public bool IsAlive { get; set; }

        public ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
}
