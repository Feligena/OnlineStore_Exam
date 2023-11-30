using OnlineStore_Exam.Areas.Admin.Models;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore_Exam.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required, StringLength(10)]
        public string Article { get; set; }

        [Required, MinLength(2), MaxLength(20)]
        public string Title { get; set; }

        [Required]
        public double Prise { get; set; }

        [Required, MaxLength(600)]
        public string Description { get; set; }

        [Required, MaxLength(600)]
        public string Specification { get; set; }

        [Display(Name ="Category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [Display(Name = "Promotion")]
        public int? PromotionId { get; set; }
        public Promotion? Promotion { get; set; }

        public IEnumerable<Images> Images { get; set;}
        
        public bool IsDeleted { get; set; } = false;
        public bool IsFavorites { get; set; } = false;
    }
}
