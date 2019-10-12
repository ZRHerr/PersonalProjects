using DotNetCore.Validation;
using QuickFix.CrossCutting.Resources;
using FluentValidation;

namespace QuickFix.Model
{
    public sealed class SignInModelValidator : Validator<SignInModel>
    {
        public SignInModelValidator()
        {
            WithMessage(Texts.LoginPasswordInvalid);
            RuleFor(x => x.Login).NotEmpty();
            RuleFor(x => x.Password).NotEmpty();
        }
    }
}
