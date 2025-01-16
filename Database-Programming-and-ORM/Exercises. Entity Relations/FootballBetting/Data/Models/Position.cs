using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBetting.Data.Models
{
    public class Position
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Player> Players { get; set; } = new List<Player>();
    }
}
