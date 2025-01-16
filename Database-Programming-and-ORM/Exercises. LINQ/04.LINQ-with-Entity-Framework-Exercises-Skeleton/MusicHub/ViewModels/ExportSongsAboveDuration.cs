using MusicHub.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicHub.ViewModels
{
    public class ExportSongsAboveDuration
    {
        public string Name { get; set; }

        public string PerformerFullName { get; set; }

        public string WriterName { get; set; }

        public string AlbumProducer { get; set; }

        public TimeSpan Duration { get; set; }
    }
}
