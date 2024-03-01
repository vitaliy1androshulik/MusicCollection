﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicCollection;

#nullable disable

namespace MusicCollection.Migrations
{
    [DbContext(typeof(MusicCollectionDBContext))]
    partial class MusicCollectionDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AlbumTrack", b =>
                {
                    b.Property<int>("AlbumsId")
                        .HasColumnType("int");

                    b.Property<int>("TracksId")
                        .HasColumnType("int");

                    b.HasKey("AlbumsId", "TracksId");

                    b.HasIndex("TracksId");

                    b.ToTable("AlbumTrack");
                });

            modelBuilder.Entity("MusicCollection.Entities.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCreate")
                        .HasMaxLength(100)
                        .HasColumnType("datetime2");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("GenreId");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistId = 1,
                            DataCreate = new DateTime(2019, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 2,
                            Name = "Loved by me",
                            Rating = 5
                        },
                        new
                        {
                            Id = 2,
                            ArtistId = 2,
                            DataCreate = new DateTime(2017, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 1,
                            Name = "Intresting world",
                            Rating = 3
                        },
                        new
                        {
                            Id = 3,
                            ArtistId = 1,
                            DataCreate = new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 3,
                            Name = "Ukraine the best",
                            Rating = 4
                        },
                        new
                        {
                            Id = 4,
                            ArtistId = 4,
                            DataCreate = new DateTime(2015, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 4,
                            Name = "Comeback",
                            Rating = 5
                        });
                });

            modelBuilder.Entity("MusicCollection.Entities.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Name = "Danulo",
                            Surname = "Rapper"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 2,
                            Name = "Mukola",
                            Surname = "Rocker"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 3,
                            Name = "Sergiy",
                            Surname = "Bondarenko"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 1,
                            Name = "Andriy",
                            Surname = "Shumaher"
                        });
                });

            modelBuilder.Entity("MusicCollection.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Rap"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Rock"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Hip-hop"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Classical"
                        });
                });

            modelBuilder.Entity("MusicCollection.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ukraine"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Poland"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Germany"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Japan"
                        });
                });

            modelBuilder.Entity("MusicCollection.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Rap"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Rock"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Hip-hop"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Classical"
                        });
                });

            modelBuilder.Entity("MusicCollection.Entities.Playlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Playlists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Name = "Love"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Name = "My country"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Name = "My little home"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            Name = "Gopdbye! Hello!"
                        });
                });

            modelBuilder.Entity("MusicCollection.Entities.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CountOfReadings")
                        .HasColumnType("int");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("PlaylistId")
                        .HasColumnType("int");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PlaylistId");

                    b.ToTable("Tracks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountOfReadings = 10000,
                            Duration = "2:32",
                            Name = "Love",
                            PlaylistId = 1,
                            Rating = 1,
                            Text = "Hello, very intresting. Goodbye"
                        },
                        new
                        {
                            Id = 2,
                            CountOfReadings = 100000,
                            Duration = "3:32",
                            Name = "My country",
                            PlaylistId = 2,
                            Rating = 5,
                            Text = "Goodbye Poland"
                        },
                        new
                        {
                            Id = 3,
                            CountOfReadings = 7500,
                            Duration = "4:10",
                            Name = "My little home",
                            PlaylistId = 1,
                            Rating = 3,
                            Text = "Hello my home, how are you?"
                        },
                        new
                        {
                            Id = 4,
                            CountOfReadings = 75000,
                            Duration = "1:50",
                            Name = "Gopdbye! Hello!",
                            PlaylistId = 3,
                            Rating = 5,
                            Text = "Gopdbye! Hello!"
                        });
                });

            modelBuilder.Entity("AlbumTrack", b =>
                {
                    b.HasOne("MusicCollection.Entities.Album", null)
                        .WithMany()
                        .HasForeignKey("AlbumsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicCollection.Entities.Track", null)
                        .WithMany()
                        .HasForeignKey("TracksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MusicCollection.Entities.Album", b =>
                {
                    b.HasOne("MusicCollection.Entities.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicCollection.Entities.Genre", "Genre")
                        .WithMany("Albums")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("MusicCollection.Entities.Artist", b =>
                {
                    b.HasOne("MusicCollection.Entities.Country", "Country")
                        .WithMany("Artists")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("MusicCollection.Entities.Playlist", b =>
                {
                    b.HasOne("MusicCollection.Entities.Category", "Category")
                        .WithMany("Playlists")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("MusicCollection.Entities.Track", b =>
                {
                    b.HasOne("MusicCollection.Entities.Playlist", "Playlist")
                        .WithMany("Tracks")
                        .HasForeignKey("PlaylistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Playlist");
                });

            modelBuilder.Entity("MusicCollection.Entities.Artist", b =>
                {
                    b.Navigation("Albums");
                });

            modelBuilder.Entity("MusicCollection.Entities.Category", b =>
                {
                    b.Navigation("Playlists");
                });

            modelBuilder.Entity("MusicCollection.Entities.Country", b =>
                {
                    b.Navigation("Artists");
                });

            modelBuilder.Entity("MusicCollection.Entities.Genre", b =>
                {
                    b.Navigation("Albums");
                });

            modelBuilder.Entity("MusicCollection.Entities.Playlist", b =>
                {
                    b.Navigation("Tracks");
                });
#pragma warning restore 612, 618
        }
    }
}
