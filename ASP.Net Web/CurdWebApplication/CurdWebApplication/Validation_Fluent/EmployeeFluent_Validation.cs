using CurdWebApplication.Controllers;
using CurdWebApplication.Models;
using FluentValidation;

namespace CurdWebApplication.Validation_Fluent
{
    public class EmployeeFluent_Validation:AbstractValidator<Employee>
    {

        public EmployeeFluent_Validation()
        {

            // ID
            RuleFor(e => e.Id)
                .GreaterThan(0)
                .WithMessage("ID Grether Than Zero");

            // name
            RuleFor(e => e.Name)
                .NotEmpty().WithMessage("Enter name  ")
                 .Must(name => string.IsNullOrWhiteSpace(name));


            // 
            RuleFor(e => e.Designation)
                 .NotEmpty().WithMessage("Enter Designation ");

            //
            RuleFor(e => e.Role)
                .NotEmpty()
                .WithMessage("Enter role ");




    }
}

}
