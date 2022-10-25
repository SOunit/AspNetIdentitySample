using Microsoft.AspNet.Identity.EntityFramework;

namespace AspNetIdentitySample.Identity
{
    public class ApplicationUserStore : UserStore<ApplicationUser>
    {
        public ApplicationUserStore(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}