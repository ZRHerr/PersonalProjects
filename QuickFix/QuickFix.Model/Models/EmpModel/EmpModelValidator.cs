using DotNetCore.Validation;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickFix.Model.Models.EmpModel
{
    public class EmpModelValidator<T> : Validator<T> where T : EmpModel
    {
        protected EmpModelValidator()
        {
            RuleFor(x => x.FullName).NotEmpty();
            RuleFor(x => x.FullName.Name).NotEmpty();
            RuleFor(x => x.FullName.Surname).NotEmpty();
            RuleFor(x => x.Email).NotEmpty();
            RuleFor(x => x.EmployerName).NotEmpty();
        }
    }
}
