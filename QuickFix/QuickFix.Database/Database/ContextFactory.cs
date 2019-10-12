using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace QuickFix.Database
{
    public sealed class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Context>();

            builder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=QuickFixDB;");

            return new Context(builder.Options);
        }
    }
}
