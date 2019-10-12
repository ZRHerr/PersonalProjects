using DotNetCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuickFix.Model.Models.EmpModel;
using QuickFix.Model.Models.ForumModel;

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
