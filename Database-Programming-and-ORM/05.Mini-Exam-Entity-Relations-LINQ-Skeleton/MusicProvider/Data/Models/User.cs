using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MusicProvider.Data.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public ICollection<Playlist> Playlists { get; set; } = new List<Playlist>();
    }
}
