using Microsoft.EntityFrameworkCore;
using MusicCollection.Entities;
using MusicCollection.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection
{
    public class MusicCollectionDBContext:DbContext
    { 
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Track> Tracks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;
                                        Initial Catalog=MusicCollectionMigration;
                                        Integrated Security=True;
                                        Connect Timeout=5;
                                        Encrypt=False;
                                        Trust Server Certificate=False;
                                        Application Intent=ReadWrite;
                                        Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Album>()
                .HasOne(a => a.Artist)
                .WithMany(a => a.Albums)
                .HasForeignKey(a => a.ArtistId);
            modelBuilder.Entity<Album>()
                .HasOne(a => a.Genre)
                .WithMany(a => a.Albums)
                .HasForeignKey(a => a.GenreId);
            modelBuilder.Entity<Album>()
                .HasMany(a => a.Tracks)
                .WithMany(a => a.Albums);

            modelBuilder.Entity<Artist>()
                .HasOne(a => a.Country)
                .WithMany(a => a.Artists)
                .HasForeignKey(a => a.CountryId);

            modelBuilder.Entity<Playlist>()
                .HasOne(a => a.Category)
                .WithMany(a => a.Playlists)
                .HasForeignKey(a => a.CategoryId);

            modelBuilder.Entity<Track>()
                 .HasOne(a => a.Playlist)
                 .WithMany(a => a.Tracks)
                 .HasForeignKey(a => a.PlaylistId);


            
        }
    }
}
