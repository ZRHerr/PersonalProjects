using System.Threading.Tasks;

namespace QuickFix.Database
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
    }
}
