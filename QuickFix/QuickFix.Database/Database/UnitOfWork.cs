using System.Threading.Tasks;

namespace QuickFix.Database
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(Context context)
        {
            Context = context;
        }

        private Context Context { get; }

        public Task<int> SaveChangesAsync()
        {
            return Context.SaveChangesAsync();
        }
    }
}
