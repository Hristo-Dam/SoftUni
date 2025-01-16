using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace ShopDatabase.Data.Models
{
    public class Purchase
    {
        [Key]
        public int Id { get; set; }

        public DateTime DateOfPurchase { get; set; }

        [ForeignKey(nameof(Shop))]
        public int ShopId { get; set; }
        public Shop Shop { get; set; }

        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();

    }
}
