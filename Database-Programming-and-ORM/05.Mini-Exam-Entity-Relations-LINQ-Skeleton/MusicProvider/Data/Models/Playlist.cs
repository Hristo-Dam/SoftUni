using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MusicProvider.Data.Models
{
    public class Playlist
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string PlaylistName { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<PlaylistSong> PlaylistsSongs { get; set; } = new List<PlaylistSong>();
    }
}
