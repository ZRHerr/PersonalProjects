using DotNetCore.Objects;
using QuickFix.Model;

namespace QuickFix.Infrastructure
{
    public interface ISignInService
    {
        SignInModel CreateSignIn(SignInModel signInModel);

        TokenModel CreateToken(SignedInModel signedInModel);

        IResult Validate(SignedInModel signedInModel, SignInModel signInModel);
    }
}
