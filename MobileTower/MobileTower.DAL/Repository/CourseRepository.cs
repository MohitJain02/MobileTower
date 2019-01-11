using MobileTower.DAL.DBContext;
using MobileTower.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MobileTower.DAL.Repository
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(MobileTowerDbContext mobileTowerDbContext)
            : base(mobileTowerDbContext)
        {

        }

        public IEnumerable<Course> GetCourseWithAuthors(int pageIndex, int pageSize = 10)
        {
            return MobileTowerDbContext.Courses
                     .Include(x => x.Author)
                     .OrderBy(x => x.CourseName)
                     .Skip((pageIndex - 1) * pageSize)
                     .Take(pageSize)
                     .ToList();
        }

        public IEnumerable<Course> GetTopSellingCourses(int count)
        {
            return MobileTowerDbContext.Courses.OrderByDescending(x => x.FullPrice).Take(count).ToList();
        }

        public MobileTowerDbContext MobileTowerDbContext
        {
            get
            {
                return Context as MobileTowerDbContext;
            }
        }
    }
}
