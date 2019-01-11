using System.Collections.Generic;

namespace MobileTower.Entities
{
    public class Author
    {
        public int AuthorId { get; set; }

        public string Name { get; set; }

        public ICollection<Course> AuthorCourses { get; set; }
    }
}
