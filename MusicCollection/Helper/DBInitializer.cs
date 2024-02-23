using Microsoft.EntityFrameworkCore;
using MusicCollection.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection.Helper
{
    public class DBInitializer
    {
        public static void SeedCountry(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(new Country[]
            { 
                new Country
                {
                    Id=1,
                    Name="Ukraine"
                },
                new Country
                {
                    Id=2,
                    Name="Poland"
                },
                new Country
                {
                    Id=3,
                    Name="Germany"
                },
                new Country
                {
                    Id=4,
                    Name="Japan"
                }
            });
        }
        public static void SeedCategory(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category[]
            {
                new Category
                {
                    Id=1,
                    Name="Rap"
                },
                new Category
                {
                    Id=2,
                    Name="Rock"
                },
                new Category
                {
                    Id=3,
                    Name="Hip-hop"
                },
                new Category
                {
                    Id=4,
                    Name="Classical"
                }
            });
        }
        public static void SeedGenre(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(new Genre[]
            {
                new Genre
                {
                    Id=1,
                    Name="Rap"
                },
                new Genre
                {
                    Id=2,
                    Name="Rock"
                },
                new Genre
                {
                    Id=3,
                    Name="Hip-hop"
                },
                new Genre
                {
                    Id=4,
                    Name="Classical"
                }
            });
        }
        public static void SeedArtist(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>().HasData(new Artist[]
            {
                new Artist
                {
                    Id=1,
                    Name="Danulo",
                    Surname="Rapper",
                    CountryId=1
                },
                new Artist
                {
                    Id=2,
                    Name="Mukola",
                    Surname="Rocker",
                    CountryId=2
                },
                new Artist
                {
                    Id=3,
                    Name="Sergiy",
                    Surname="Bondarenko",
                    CountryId=3
                },
                new Artist
                {
                    Id=4,
                    Name="Andriy",
                    Surname="Shumaher",
                    CountryId=1
                }
            });
        }
        public static void SeedPlaylist(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Playlist>().HasData(new Playlist[]
            {
                new Playlist
                {
                    Id=1,
                    Name="Love",
                    CategoryId=1
                },
                new Playlist
                {
                    Id=2,
                    Name="My country",
                    CategoryId=2
                },
                new Playlist
                {
                    Id=3,
                    Name="My little home",
                    CategoryId=1
                },
                new Playlist
                {
                    Id=4,
                    Name="Gopdbye! Hello!",
                    CategoryId=3
                }
            });
        }

        public static void SeedTrack(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Track>().HasData(new Track[]
            {
                new Track
                {
                    Id=1,
                    Name="Love",
                    PlaylistId=1
                },
                new Track
                {
                    Id=2,
                    Name="My country",
                    PlaylistId=2
                },
                new Track
                {
                    Id=3,
                    Name="My little home",
                    PlaylistId=1
                },
                new Track
                {
                    Id=4,
                    Name="Gopdbye! Hello!",
                    PlaylistId=3
                }
            });
        }
        public static void SeedAlbum(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData(new Album[]
            {
                new Album
                {
                    Id=1,
                    Name="Loved by me",
                    DataCreate =new DateTime(2019,4,12),
                    ArtistId=1,
                    GenreId=2
                },
                new Album
                {
                    Id=2,
                    Name="Intresting world",
                    DataCreate =new DateTime(2017,2,17),
                    ArtistId=2,
                    GenreId=1
                },
                new Album
                {
                    Id=3,
                    Name="Ukraine the best",
                    DataCreate =new DateTime(2022,2,25),
                    ArtistId=1,
                    GenreId=3
                },
                new Album
                {
                    Id=4,
                    Name="Comeback",
                    DataCreate =new DateTime(2015,1,10),
                    ArtistId=4,
                    GenreId=4
                }
            });
        }
    }
}
