using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        //[Required(ErrorMessage = "First Name cannot be empty!")]
        //[MinLength(3, ErrorMessage = "First Name must have at least 3 characters")]
        //[MaxLength(10, ErrorMessage = "First Name could not have more than 10 characters")]
        public string FirstName { get; set; }

        //[Required(ErrorMessage = "Last Name cannot be empty!")]
        //[MinLength(3, ErrorMessage = "Last Name must have at least 3 characters")]
        //[MaxLength(20, ErrorMessage = "Last Name could not have more than 20 characters")]
        public string LastName { get; set; }

        //[Required(ErrorMessage = "Title cannot be empty!")]
        //[MinLength(3, ErrorMessage = "Title must have at least 3 characters")]
        //[MaxLength(30, ErrorMessage = "Title could not have more than 30 characters")]
        public string? Title { get; set; }
        public ICollection<Order> Orders { get; set; }
        public Employee()
        {
            Orders = new List<Order>();
        }
    }
}
