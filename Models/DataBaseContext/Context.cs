using Microsoft.EntityFrameworkCore;
using TestTask.Models.Entities;

namespace TestTask.Models.DataBaseContext
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<FormPost> FormPost { get; set; }
    }
}
