using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aref_final.Models
{
    public class Toy
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; } = decimal.Zero;
        public string Category { get; set; } = string.Empty;
        
        [Display(Name = "Image File Name")]
        public string ImageFileName { get; set; } = string.Empty;
    }
}
