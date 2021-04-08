namespace VajaCodeFirst1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Račun",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Vrednost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DatumIzdaje = c.DateTime(nullable: false),
                        Kupec_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kupecs", t => t.Kupec_Id)
                .Index(t => t.Kupec_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Račun", "Kupec_Id", "dbo.Kupecs");
            DropIndex("dbo.Račun", new[] { "Kupec_Id" });
            DropTable("dbo.Račun");
        }
    }
}
