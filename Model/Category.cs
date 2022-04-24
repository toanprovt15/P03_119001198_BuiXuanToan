using System.ComponentModel.DataAnnotations;

namespace BuiXuanToan.Model
{
    public class Category
    {
        [Key]

        public int ID { get; set; }
        [Required]
        [MaxLength(200)]
        public string? Name { get; set; }
    }

}