using System.ComponentModel.DataAnnotations;

namespace OnlineStore_Exam.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        public IEnumerable<Product> Products { get; set; }

        public int CategoryImageId { get; set; }
        public CategoryImage CategoryImage { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
