using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBetting.Data.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(HomeTeam))]
        public int HomeTeamId { get; set; }
        public Team HomeTeam { get; set; }

        [ForeignKey(nameof(AwayTeam))]
        public int AwayTeamId { get; set; }
        public Team AwayTeam { get; set; }

        public int HomeTeamGoals { get; set; }

        public int AwayTeamGoals { get; set; }

        public DateTime DateTime { get; set; }

        public float HomeTeamBetRate { get; set; }

        public float AwayTeamBetRate { get; set; }

        public float DrawBetRate { get; set; }

        public string Result { get; set; }

        public ICollection<PlayerStatistic> PlayerStatistics { get; set; } = new List<PlayerStatistic>();

        public ICollection<Bet> Bets { get; set; } = new List<Bet>();

    }
}
