namespace DevMediaMigracao.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DevMediaMigracao.Infraestrutura.Data.LojaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "DevMediaMigracao.Infraestrutura.Data.LojaContext";
        }

        protected override void Seed(DevMediaMigracao.Infraestrutura.Data.LojaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
