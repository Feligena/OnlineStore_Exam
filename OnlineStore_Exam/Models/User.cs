using System.ComponentModel.DataAnnotations;

namespace OnlineStore_Exam.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required, MinLength(2), MaxLength(20)]
        public string Name { get; set; }

        [Required, MinLength(2), MaxLength(50)]
        [Display(Name = "Surname ")]
        public string SurName { get; set; }

        [Required, MinLength(2), MaxLength(20)]
        [EmailAddress]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        public string Password { get; set; }

        public bool IsDeleted { get; set; } = false;

    }
}
