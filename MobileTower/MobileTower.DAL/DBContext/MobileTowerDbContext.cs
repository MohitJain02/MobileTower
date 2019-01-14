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
            // configure default schema
            modelBuilder.HasDefaultSchema("Admin");

            // map entity to the table

            modelBuilder.Entity<Course>().ToTable("CourseInfo");


            // map to multiple tables from a single entity
            modelBuilder.Entity<Course>().Map(m =>
            {
                m.Properties(p => new { p.CourseId, p.CourseName });
                m.ToTable("StudentInfo");
            }).Map(m => {
                m.Properties(p => new { p.CourseId, p.CourseName });
                m.ToTable("StudentInfoDetail");
            });


            base.OnModelCreating(modelBuilder);
        }
    }
}
