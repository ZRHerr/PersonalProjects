using DotNetCore.EntityFrameworkCore;
using QuickFix.Domain;

namespace QuickFix.Database
{
    public sealed class UserLogRepository : EntityFrameworkCoreRelationalRepository<UserLogEntity>, IUserLogRepository
    {
        public UserLogRepository(Context context) : base(context)
        {
        }
    }
}
