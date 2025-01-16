using MusicHub.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicHub.ViewModels
{
    public class ExportAlbumsInfo
    {
        public int ProducerId { get; set; }

        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string ProducerName { get; set; }

        public ICollection<Song> AlbumSongs { get; set; }

        public decimal AlbumTotalPrice {  get; set; }
    }
}
