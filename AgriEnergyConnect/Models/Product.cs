using System.ComponentModel.DataAnnotations;

namespace AgriEnergyConnect.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string? ProductName { get; set; }

        public string? ProductCode { get; set; }

        public decimal PricePerKg { get; set; }

        public DateTime HarvestDate { get; set; }

        public int FarmerId { get; set; } // Foreign Key
    }
}