using DotNetCore.Repositories;
using QuickFix.Domain;
using QuickFix.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuickFix.Database
{
    public interface IUserRepository : IRelationalRepository<UserEntity>
    {
        Task<SignedInModel> SignInAsync(SignInModel signInModel);

        Task UpdateStatusAsync(UserEntity userEntity);

    }
}
