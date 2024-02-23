using System.ComponentModel.DataAnnotations;

namespace MusicCollection.Entities
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        public ICollection<Artist> Artists { get; set; }
    }
}
