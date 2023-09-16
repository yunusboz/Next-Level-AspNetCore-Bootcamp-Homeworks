using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Validations
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(e => e.FirstName).NotEmpty().WithMessage("First Name cannot be empty!")
                .MinimumLength(3).WithMessage("First Name must have at least 3 characters")
                .MaximumLength(10).WithMessage("First Name could not have more than 10 characters");

            RuleFor(e => e.LastName).NotEmpty().WithMessage("Last Name cannot be empty!")
                .MinimumLength(3).WithMessage("Last Name must have at least 3 characters")
                .MaximumLength(20).WithMessage("Last Name could not have more than 20 characters");

            RuleFor(e => e.Title).NotEmpty().WithMessage("Title cannot be empty!")
                .MinimumLength(3).WithMessage("Title must have at least 3 characters")
                .MaximumLength(30).WithMessage("Title could not have more than 30 characters");

        }
    }
}
