namespace OnlineStore_Exam.Models
{
    public class CategoryImage : Images
    {
        public int Id { get; set; }

        public IEnumerable<Category> Categories { get; set; }
    }
}
