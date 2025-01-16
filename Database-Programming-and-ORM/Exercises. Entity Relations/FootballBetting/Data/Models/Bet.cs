using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBetting.Data.Models
{
    public class Bet
    {
        [Key]
        public int Id { get; set; }

        public decimal Amount { get; set; }

        [Required]
        public string Prediction { get; set; }

        public DateTime DateTime { get; set; }

        public int UserId { get; set; }

        [ForeignKey(nameof(Game))]
        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}
