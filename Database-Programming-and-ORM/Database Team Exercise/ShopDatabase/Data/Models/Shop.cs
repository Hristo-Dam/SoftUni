using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ShopDatabase.Data.Models
{
    public class Shop
    {
        [Key]
        public int Id { get; set; }

        public string Address { get; set; }

        public bool IsActive { get; set; }

        // Many-to-Many relation with Product
        public ICollection<ShopProduct> ShopProducts { get; set; } = new List<ShopProduct>();

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();

    }
}
