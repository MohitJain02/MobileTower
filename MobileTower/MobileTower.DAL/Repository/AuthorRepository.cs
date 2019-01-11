using MobileTower.DAL.DBContext;
using MobileTower.Entities;

namespace MobileTower.DAL.Repository
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(MobileTowerDbContext mobileTowerDbContext)
          : base(mobileTowerDbContext)
        {

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
