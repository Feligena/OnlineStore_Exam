using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace OnlineStore_Exam.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        public IEnumerable<Product> Products { get; set; }

        public Images? Image { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
