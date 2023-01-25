using Microsoft.EntityFrameworkCore;

namespace ExpenseAPI.Models
{
    public class ExpenseDetailContext : DbContext
    {
        public ExpenseDetailContext(DbContextOptions<ExpenseDetailContext> options) : base(options)
        {

        }

        public DbSet<ExpenseDetail> ExpenseDetails { get; set; }
        public DbSet<User> User { get; set; }

    }
}

