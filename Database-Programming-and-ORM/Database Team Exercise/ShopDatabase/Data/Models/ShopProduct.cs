using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDatabase.Data.Models
{
    // Mapping table for many-to-many relation between Shop and Product
    public class ShopProduct
    {
        //[ForeignKey(nameof(Shop))] -> You can use this instead of fluent API
        public int ShopId { get; set; }
        public Shop Shop { get; set; }

        //[ForeignKey(nameof(Product))] -> You can use this instead of fluent API
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
