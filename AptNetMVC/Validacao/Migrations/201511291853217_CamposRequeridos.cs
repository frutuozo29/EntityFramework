namespace Validacao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CamposRequeridos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Jogadors", "Nome", c => c.String(nullable: false));
            AlterColumn("dbo.Jogadors", "Numero", c => c.Int(nullable: false));
            AlterColumn("dbo.Jogadors", "Altura", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Jogadors", "Altura", c => c.Double());
            AlterColumn("dbo.Jogadors", "Numero", c => c.Int());
            AlterColumn("dbo.Jogadors", "Nome", c => c.String());
        }
    }
}
