namespace MobileTower.DAL
{
    public class Class1
    {
        // use Unit of work

        void Main()
        {
            using (var unitofWork = new UnitOfWork(new DBContext.MobileTowerDbContext()))
            {
                // Example 1 
                var course = unitofWork.Courses.Get(1);

                // Example 2
                var courses = unitofWork.Courses.GetCourseWithAuthors(1, 4);

                //Example 3

                var author = unitofWork.Author.Get(1);
                unitofWork.Courses.RemoveRange(author.AuthorCourses);
                unitofWork.Author.Remove(author);

                unitofWork.Complete();
            }
        }
    }
}
