using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBetting.Data.Models
{
    public class Color
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Team> PrimaryKitTeams { get; set; } = new List<Team>();

        public ICollection<Team> SecondKitTeams { get; set; } = new List<Team>();
    }
}
