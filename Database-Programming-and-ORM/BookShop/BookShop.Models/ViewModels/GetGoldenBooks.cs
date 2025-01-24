using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop.Models.ViewModels
{
    public class GetGoldenBooks
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int Copies { get; set; }
        public int EditionType { get; set; }
    }
}
