using OnlineStore_Exam.Models;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore_Exam.Areas.Admin.Models
{
    public class Promotion
    {
        public int Id { get; set; }

        [Required, MinLength(2), MaxLength(20)]
        public string Title { get; set; }

        [Required, MinLength(2), MaxLength(1000)]
        public string Details { get; set; }

        [Required]
        public double Percent {  get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime ExpirationDate { get; set; }
        public IEnumerable<Product>? Products { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
