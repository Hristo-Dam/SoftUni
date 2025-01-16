using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MusicProvider.Data.Models
{
    public class PlaylistSong
    {
        [ForeignKey(nameof(Song))]
        public int SongId { get; set; }
        public Song Song { get; set; }

        [ForeignKey(nameof(Playlist))]
        public int PlaylistId { get; set; }
        public Playlist Playlist { get; set; }
    }
}
