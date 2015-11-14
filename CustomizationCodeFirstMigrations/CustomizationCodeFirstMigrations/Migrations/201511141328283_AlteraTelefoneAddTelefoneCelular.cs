namespace CustomizationCodeFirstMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteraTelefoneAddTelefoneCelular : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Email = c.String(),
                        TelefoneFixo = c.String(nullable: false),
                        TelefoneCelular = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pessoas");
        }
    }
}
