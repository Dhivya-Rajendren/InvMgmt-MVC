using Microsoft.EntityFrameworkCore;

namespace InvMgmt_MVC.Models
{
    public class InvMgmtDbContext:DbContext
    {

        public InvMgmtDbContext(DbContextOptions<InvMgmtDbContext>options ):base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
    }
}
