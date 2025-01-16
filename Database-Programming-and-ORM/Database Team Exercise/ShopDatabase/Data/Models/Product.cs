using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Storage;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopDatabase.Data.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Category { get; set; }

        public decimal Price { get; set; }

        public bool IsBeingSold { get; set; }

        public string Description {  get; set; }

        // Many-to-Many relation with Shop
        public ICollection<ShopProduct> ShopProducts { get; set; } = new List<ShopProduct>();
    }
}
