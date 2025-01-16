using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBetting.Data.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int SquadNumber { get; set; }

        [ForeignKey(nameof(Country))]
        public int TeamId { get; set; }
        public Team Team { get; set; }

        [ForeignKey(nameof(Position))]
        public int PositionId { get; set; }
        public Position Position { get; set; }

        public bool IsInjured { get; set; }

        public ICollection<PlayerStatistic> PlayerStatistics { get; set; } = new List<PlayerStatistic>();
    }
}
