using Microsoft.AspNet.Identity.EntityFramework;

namespace AspNetIdentitySample.Identity
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {

        }
    }
}