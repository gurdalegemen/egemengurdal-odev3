using Microsoft.EntityFrameworkCore;
using OdevApi.Data.Model;
using System.Reflection;

namespace OdevApi.Data.Context
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Account> Account { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
