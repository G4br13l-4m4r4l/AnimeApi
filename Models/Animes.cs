using System.ComponentModel.DataAnnotations;

namespace Anime.Models
{
    public class Animes
    {
        [Key]
        public int AnimeId { get; set; }
        [Required]
        [StringLength(300)]
        public string? Title { get; set;}
        [StringLength(500)]

        public string? ImagemUrl { get; set; }
        public int QuantidadeEp { get; set; }
        [StringLength(50)]
        public string Categoria { get; set; }
    }
}
