using Microsoft.EntityFrameworkCore;
using MusicCollection.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection
{
    public class MusicCollectionDBContext:DbContext
    {
        public MusicCollectionDBContext()
        {
            //this.Database.EnsureCreated();
            //this.Database.EnsureCreated();
        }
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
                                        Initial Catalog=MusicCollection;
                                        Integrated Security=True;
                                        Connect Timeout=5;
                                        Encrypt=False;
                                        Trust Server Certificate=False;
                                        Application Intent=ReadWrite;
                                        Multi Subnet Failover=False");
        }

    }
    


}
