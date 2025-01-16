using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBetting.Data.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Country> Countries { get; set; } = new List<Country>();
    }
}
