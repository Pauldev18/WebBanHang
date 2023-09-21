using System.ComponentModel.DataAnnotations;

namespace WebBanHang.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
        [Range(1,100, ErrorMessage ="Must 1 to 100")]
        public int DisplayOrder { get; set; }
    }
}
