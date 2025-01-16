using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MusicProvider.Data.Models
{
    public class Song
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(120)]
        public string SongName { get; set; }

        [MaxLength(150)]
        public string SongArtist { get; set; }

        public ICollection<PlaylistSong> PlaylistsSongs { get; set; } = new List<PlaylistSong>();
    }
}
