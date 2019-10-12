using DotNetCore.Repositories;
using QuickFix.Domain;

namespace QuickFix.Database
{
    public interface IUserLogRepository : IRelationalRepository<UserLogEntity> { }
}
