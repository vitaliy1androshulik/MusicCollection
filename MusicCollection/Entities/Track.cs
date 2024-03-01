using System.ComponentModel.DataAnnotations;

namespace MusicCollection.Entities
{
    public class Track
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        public ICollection<Album> Albums { get; set; }
        [Required, MaxLength(100)]
        public string Duration { get; set; }
        public Playlist Playlist { get; set; }
        public int PlaylistId { get; set; }
        public int? Rating { get; set; }
        public int? CountOfReadings { get; set; }
        public string Text { get; set; }

    }
}
