using FluentValidation;

namespace QuickFix.Model.Models.EmpModel
{
    public sealed class UpdateEmpModelValidator : EmpModelValidator<UpdateEmpModel>
    {
        public UpdateEmpModelValidator()
        {
            RuleFor(x => x.EmpId).NotEmpty();
            RuleFor(x => x.UserId).NotEmpty();
        }
    }
}