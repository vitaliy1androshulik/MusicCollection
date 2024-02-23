using System.ComponentModel.DataAnnotations;

namespace MusicCollection.Entities
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        public ICollection<Album> Albums { get; set; }
    }
}
