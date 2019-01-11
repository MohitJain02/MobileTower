using MobileTower.Entities;
using System.Collections.Generic;

namespace MobileTower.DAL.Repository
{
    public interface ICourseRepository : IRepository<Course>
    {
        IEnumerable<Course> GetTopSellingCourses(int count);

        IEnumerable<Course> GetCourseWithAuthors(int pageIndex, int pageSize);
    }
}
