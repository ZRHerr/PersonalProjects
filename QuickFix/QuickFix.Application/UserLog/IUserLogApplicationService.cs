using QuickFix.Model;
using System.Threading.Tasks;

namespace QuickFix.Application
{
    public interface IUserLogApplicationService
    {
        Task AddAsync(UserLogModel userLogModel);
    }
}
