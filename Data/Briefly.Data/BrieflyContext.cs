namespace Briefly.Data
{
    using Briefly.Data.Migrations;
    using Briefly.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;

    public class BrieflyContext : IdentityDbContext<User>
    {
        public BrieflyContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BrieflyContext, Configuration>());
        }

        public IDbSet<User> Users { get; set; }

        public IDbSet<User> Followers { get; set; }

        public IDbSet<User> Followees { get; set; }

        public IDbSet<Brief> Briefs { get; set; }

        public IDbSet<AdministartionLog> Logs { get; set; }

        public static BrieflyContext Create()
        {
            return new BrieflyContext();
        }
    }
}
