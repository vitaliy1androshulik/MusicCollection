using System.ComponentModel.DataAnnotations;

namespace MusicCollection.Entities
{
    public class Album
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required, MaxLength(100)]
        public DateTime DataCreate { get; set; }
        [Required, MaxLength(100)]
        public ICollection<Track> Tracks { get; set; }
        public Artist Artist { get; set; }
        public int ArtistId { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public int? Rating { get; set; }
    }
}
