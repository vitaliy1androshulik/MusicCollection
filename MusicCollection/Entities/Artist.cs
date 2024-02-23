using System.ComponentModel.DataAnnotations;

namespace MusicCollection.Entities
{
    public class Artist
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required, MaxLength(100)]
        public string Surname { get; set; }

        [Required, MaxLength(100)]
        public Country Country { get; set; }
        public int CountryId { get; set; }
        public ICollection<Album> Albums { get; set; }
    }
}
