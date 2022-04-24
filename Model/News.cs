using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuiXuanToan.Model
{
    public class News
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(200)]
        [MinLength(50)]
        public string? Title { get; set; }
        [Required]
        public string? ImageUrl { get; set; }
        [Required]
        [MaxLength(500)]
        [MinLength(100)]
        public string? Content { get; set; }
        [Required]
        public string? Author { get; set; }

        public DateTime CreatedAt { get; set; }

        [ForeignKey("CategotyID")]

        public Category? Category{get; set; }

        public ICollection<comment>? comments{get; set; }
        
    }
}