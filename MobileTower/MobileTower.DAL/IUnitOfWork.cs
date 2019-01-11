using MobileTower.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileTower.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRepository Courses { get; }
        IAuthorRepository Author { get; }
        int Complete();
    }
}
