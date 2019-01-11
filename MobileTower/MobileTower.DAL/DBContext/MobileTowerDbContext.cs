using MobileTower.Entities;
using System.Data.Entity;

namespace MobileTower.DAL.DBContext
{
    public class MobileTowerDbContext : DbContext
    {
        public MobileTowerDbContext()
            :base ("MydbConn")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<MobileTowerDbContext>());
        }

        public DbSet<Login> Logins { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }


        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
