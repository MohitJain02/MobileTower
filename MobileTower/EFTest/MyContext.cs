using System.Data.Entity;

namespace EFTest
{
    public class MyContext : DbContext
    {
        public MyContext()
             : base("MydbConn")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<MyContext>());

        }

        public DbSet<Employee> Employees { get; set; }

    }
}
