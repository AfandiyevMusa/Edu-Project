namespace Edu.Models
{
    public class Course : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StudentsCount { get; set; }
        public ICollection<CourseImg> CourseImgs { get; set; }
    }
}
