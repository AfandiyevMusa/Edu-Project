namespace Edu.Models
{
    public class CourseImg:BaseEntity
    {
        public string Image { get; set; }
        public bool IsMain { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
