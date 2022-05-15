using System.ComponentModel.DataAnnotations;

namespace BlazorShared.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 10)]
        public string ProductPartNumber { get; set; }

        [Required]
        [Range(1, 999)]
        public int Quantity { get; set; }

        [Required]
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        [Range(0, 9999999999999999.99)]
        public decimal Price { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public string UserName { get; set; }
    }
}
