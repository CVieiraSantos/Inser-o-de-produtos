namespace DevMediaMigracao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MarcaProduto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produtos", "Marca", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produtos", "Marca");
        }
    }
}
