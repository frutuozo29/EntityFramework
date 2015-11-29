namespace Validacao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jogadors",
                c => new
                    {
                        JogadorID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Numero = c.Int(),
                        Altura = c.Double(),
                    })
                .PrimaryKey(t => t.JogadorID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Jogadors");
        }
    }
}
