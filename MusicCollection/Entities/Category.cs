using System.ComponentModel.DataAnnotations;

namespace MusicCollection.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        public ICollection<Playlist> Playlists { get; set; }
    }
}
