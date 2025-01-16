namespace MusicHub
{
    using System;
    using System.Linq;
    using System.Text;
    using Data;
    using Initializer;
    using MusicHub.Data.Models;
    using MusicHub.ViewModels;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            MusicHubDbContext context = 
                new MusicHubDbContext();

            DbInitializer.ResetDatabase(context);
            Console.WriteLine(); // Remove for Judge !!!

            //Test your solutions here
            //Console.WriteLine(ExportAlbumsInfo(context, 9));

            Console.WriteLine(ExportSongsAboveDuration(context, 4));
        }

        public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
        {
            
            var albums = context.Albums
                .Select(a => new ExportAlbumsInfo
                {
                    ProducerId = a.Producer.Id,
                    Name = a.Name,
                    ReleaseDate = a.ReleaseDate,
                    ProducerName = a.Producer.Name,
                    AlbumTotalPrice = a.Price,
                    AlbumSongs = a.Songs
                        .OrderByDescending(s => s.Name)
                        .ThenBy(s => s.Writer.Name)
                        .ToList()
                })
                .ToList();

            var result = albums
                .Where(a => a.ProducerId == producerId)
                .OrderByDescending(a => a.AlbumTotalPrice)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var album in result)
            {
                sb.AppendLine($"-AlbumName: {album.Name}");
                sb.AppendLine($"-ReleaseDate: {album.ReleaseDate.Month}/{album.ReleaseDate.Day}/{album.ReleaseDate.Year}");
                sb.AppendLine($"-ProducerName: {album.ProducerName}");
                sb.AppendLine("-Songs:");

                int songCount = 1;
                foreach(Song song in album.AlbumSongs)
                {
                    sb.AppendLine($"---#{songCount}");
                    sb.AppendLine($"---SongName: {song.Name}");
                    sb.AppendLine($"---Price: {song.Price:F2}");
                    sb.AppendLine($"---Writer: {song.Writer.Name}");

                    songCount++;
                }

                sb.AppendLine($"-AlbumPrice: {album.AlbumTotalPrice:F2}");
                sb.AppendLine(); // Remove for Judge!!!
            }

            return sb.ToString().Trim();
        }

        public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {
            var songs = context.Songs
                .Select(s => new ExportSongsAboveDuration
                {
                    Name = s.Name,
                    PerformerFullName = s.SongsPerformers
                        .Select(sp => sp.Performer.FirstName + " " + sp.Performer.LastName)
                        .FirstOrDefault(),
                    WriterName = s.Writer.Name,
                    AlbumProducer = s.Album.Producer.Name,
                    Duration = s.Duration
                })
                .ToList();

            var result = songs
                .Where(s => s.Duration.Minutes >= duration)
                .OrderBy(s => s.Name)
                .ThenBy(s => s.WriterName)
                .ThenBy(s => s.PerformerFullName)
                .ToList();

            StringBuilder sb = new StringBuilder();
            int songCount = 1;

            foreach(var song in result)
            {
                sb.AppendLine($"-Song #{songCount}");
                sb.AppendLine($"---SongName: {song.Name}");
                sb.AppendLine($"---Writer: {song.WriterName}");
                sb.AppendLine($"---Performer: {song.PerformerFullName}");
                sb.AppendLine($"---AlbumProducer: {song.AlbumProducer}");
                sb.AppendLine($"---Duretion: {song.Duration}");

                songCount++;
            }

            return sb.ToString().Trim();
        }
    }
}
