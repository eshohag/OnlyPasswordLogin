using System.Data.Entity;

namespace OnlyPasswordLogin.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("OnlyPasswordLoginDB")
        {

        }
        public DbSet<Register> Registers { get; set; }

    }
}