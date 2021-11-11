namespace DevMediaMigracao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteraTelefoneCliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "TelefoneContato", c => c.String());
            Sql("UPDATE Clientes SET TelefoneContato = Telefone");
            DropColumn("dbo.Clientes", "Telefone");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "Telefone", c => c.String());
            Sql("UPDATE Clientes SET Telefone = TelefoneContato");
            DropColumn("dbo.Clientes", "TelefoneContato");
        }
    }
}
