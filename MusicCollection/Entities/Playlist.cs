using System.ComponentModel.DataAnnotations;

namespace MusicCollection.Entities
{
    public class Playlist
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        public ICollection<Track> Tracks { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
