namespace DevMediaMigracao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MrcaProdutoDataProduto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produtos", "DataCompra", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produtos", "DataCompra");
        }
    }
}
