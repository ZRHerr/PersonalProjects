using DotNetCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace QuickFix.Database
{
    public sealed class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly();
            builder.Seed();
        }
    }
}
