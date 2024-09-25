using Microsoft.EntityFrameworkCore;

namespace ASP_NET_Tutorial___SpendSmart.Models
{
    public class SpendSmartDbContext : DbContext 
    {
        public DbSet<Expense> Expenses { get; set; }

        public SpendSmartDbContext(DbContextOptions<SpendSmartDbContext> options)
            : base(options)
        {
            
        }
    }
}
