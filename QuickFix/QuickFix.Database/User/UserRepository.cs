using DotNetCore.EntityFrameworkCore;
using QuickFix.Domain;
using QuickFix.Model;
using QuickFix.Model.Models.ForumModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuickFix.Database
{
    public sealed class UserRepository : EntityFrameworkCoreRelationalRepository<UserEntity>, IUserRepository
    {
        public UserRepository(Context context) : base(context)
        {
        }

        public Task<SignedInModel> SignInAsync(SignInModel signInModel)
        {
            return SingleOrDefaultAsync<SignedInModel>
            (
                userEntity =>
                userEntity.SignIn.Login == signInModel.Login &&
                userEntity.Status == Status.Active
            );
        }

        public Task UpdateStatusAsync(UserEntity userEntity)
        {
            return UpdatePartialAsync(userEntity.UserId, new { userEntity.Status });
        }      
    }
}

