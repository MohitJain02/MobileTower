using System.ComponentModel.DataAnnotations;

namespace EFTest
{
    public class Employee
    {
        public Employee()
        {

        }

        [Key]
        public int EmpId { get; set; }

        public string EmpName { get; set; }

        public string Address { get; set; }
    }
}
