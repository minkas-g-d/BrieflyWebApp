namespace Briefly.Data
{
    using Briefly.Models;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class BrieflyContext : IdentityDbContext<User>
    {
        public BrieflyContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static BrieflyContext Create()
        {
            return new BrieflyContext();
        }
    }
}
