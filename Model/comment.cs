using System.ComponentModel.DataAnnotations;

namespace BuiXuanToan.Model
{
    public class comment
    {
        [Key]
        public int ID { get; set; }
        [Required]
        
        public string? Content { get; set; }
            
        [Required]
        public string? Author { get; set; }
        
        public DateTime CreatedAt { get; set; }
    }
}