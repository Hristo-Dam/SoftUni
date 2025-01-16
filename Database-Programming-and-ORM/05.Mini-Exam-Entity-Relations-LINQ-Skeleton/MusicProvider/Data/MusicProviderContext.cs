using Microsoft.EntityFrameworkCore;
using MusicProvider.Data.Models;

namespace MusicProvider.Data
{
    public class MusicProviderContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<PlaylistSong> PlaylistsSongs { get; set; }

        public MusicProviderContext()
        {
        }
        public MusicProviderContext(DbContextOptions options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlaylistSong>()
                .HasKey(ps => new { ps.SongId, ps.PlaylistId });
        }
    }
}
