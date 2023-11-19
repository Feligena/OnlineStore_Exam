using System.ComponentModel.DataAnnotations;

namespace OnlineStore_Exam.Models
{
    public class Images
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public byte[] Data { get; set; }

        public int ProductId {  get; set; }
        public Product Product { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
