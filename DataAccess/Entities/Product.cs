using AppCore.Records.Bases;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class Product : RecordBase
    {
        [Required]
        [StringLength(200)]
        public string? Name { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }
        [Required]
        public double? Price { get; set; }
        [Required]
        public int? StockAmount { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; } //bu yaptığımızla kategorinin adını da öğreniyoruz direk yoksa kategori listesinden sorgulaa yapıp kategori adını öğrenmemiz gerekiyordu

    }
}