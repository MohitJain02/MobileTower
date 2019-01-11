using MobileTower.DAL.DBContext;
using MobileTower.DAL.Repository;

namespace MobileTower.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MobileTowerDbContext _context;

        public UnitOfWork(MobileTowerDbContext mobileTowerDbContext)
        {
            _context = mobileTowerDbContext;
            Courses = new CourseRepository(_context);
            Author = new AuthorRepository(_context);
            
        }

        public ICourseRepository Courses
        {
            get;
            private set;
        }

        public IAuthorRepository Author
        {
            get;
            private set;
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
