namespace Zolla.Web.Migrations
{
    using Data.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Zolla.Web.Infrastructure.ZollaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Zolla.Web.Infrastructure.ZollaDbContext context)
        {
            
           
        }
    }
}
