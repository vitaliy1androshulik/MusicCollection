using MusicCollection.Entities;

namespace MusicCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusicCollectionDBContext context = new MusicCollectionDBContext();
            //context.Categories.Add(new Category 
            //{
            //    Name = "Rock"
            //});
            //context.Playlists.Add(new Playlist
            //{
            //     Name="Playlist1",
            //     CategoryId=1
            //});
            //
            //context.Tracks.Add(new Track
            //{
            //    Name ="First",
            //    Duration = "2:30",
            //    PlaylistId=1
            //});
            //context.Genres.Add(new Genre
            //{
            //    Name = "Rock"
            //});
            //context.Countries.Add(new Country
            //{
            //    Name = "Ukraine"
            //});
            //context.Artists.Add(new Artist
            //{
            //    Name = "Danylo",
            //    Surname = "Musicar",
            //    CountryId = 1
            //}) ;
            context.Albums.Add(new Album
            {
                Name = "New 2022 hits",
                DataCreate = new DateTime(2022, 7, 12),
                ArtistId = 4,
                GenreId = 2
            }) ;
            context.SaveChanges();
            foreach (var item in context.Tracks)
            {
                Console.WriteLine($"Track : {item.Id}, {item.Name}");
            }
            foreach (var item in context.Playlists)
            {
                Console.WriteLine($"Playlist : {item.Id}, {item.Name}");
            }
            foreach (var item in context.Albums)
            {
                Console.WriteLine($"Albums : {item.Id}, {item.Name}, {item.Genre}, {item.DataCreate}");
            }
        }
    }
}
