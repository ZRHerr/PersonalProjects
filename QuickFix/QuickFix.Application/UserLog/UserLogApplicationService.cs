using QuickFix.Database;
using QuickFix.Domain;
using QuickFix.Model;
using System.Threading.Tasks;

namespace QuickFix.Application
{
    public sealed class UserLogApplicationService : IUserLogApplicationService
    {
        public UserLogApplicationService(IUserLogRepository userLogRepository)
        {
            UserLogRepository = userLogRepository;
        }

        private IUserLogRepository UserLogRepository { get; }

        public async Task AddAsync(UserLogModel userLogModel)
        {
            var userLogEntity = UserLogEntityFactory.Create(userLogModel);

            await UserLogRepository.AddAsync(userLogEntity);
        }
    }
}
