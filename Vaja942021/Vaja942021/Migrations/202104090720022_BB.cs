namespace Vaja942021.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BB : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Kupecs", "Kontakt", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kupecs", "Kontakt", c => c.String());
        }
    }
}
