namespace AspNetIdentitySample.IdentityMigrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<AspNetIdentitySample.Identity.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"IdentityMigrations";
        }

        protected override void Seed(AspNetIdentitySample.Identity.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
