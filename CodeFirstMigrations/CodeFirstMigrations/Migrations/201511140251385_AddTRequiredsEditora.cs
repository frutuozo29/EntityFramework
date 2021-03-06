namespace CodeFirstMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTRequiredsEditora : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Editoras", "Nome", c => c.String(nullable: false));
            AlterColumn("dbo.Editoras", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Editoras", "Email", c => c.String());
            AlterColumn("dbo.Editoras", "Nome", c => c.String());
        }
    }
}
