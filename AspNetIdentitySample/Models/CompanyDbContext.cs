using System.Data.Entity;

namespace AspNetIdentitySample.Models
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext() : base("MyConnectionString")
        {

        }
        public DbSet<Brand> Brands { get; set; }
    }
}