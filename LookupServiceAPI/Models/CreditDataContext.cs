using Microsoft.EntityFrameworkCore;

namespace LookupServiceAPI.Models;

public class CreditDataContext : DbContext
{
    public CreditDataContext(DbContextOptions<CreditDataContext> options)
        : base(options)
        {

        }

        public DbSet<CreditDataItem> CreditDataItems { get; set; } = null!;
}