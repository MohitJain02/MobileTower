namespace MobileTower.Entities
{
    public class Course
    {
        public int CourseId { get; set; }

        public string CourseName { get; set; }

        public Author Author { get; set; }
        public int FullPrice { get; set; }
    }
}
