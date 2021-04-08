namespace VajaCodeFirst1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class B : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Račun", "Kupec_Id", "dbo.Kupecs");
            DropIndex("dbo.Račun", new[] { "Kupec_Id" });
            RenameColumn(table: "dbo.Račun", name: "Kupec_Id", newName: "KupecId");
            AlterColumn("dbo.Račun", "KupecId", c => c.Int(nullable: false));
            CreateIndex("dbo.Račun", "KupecId");
            AddForeignKey("dbo.Račun", "KupecId", "dbo.Kupecs", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Račun", "KupecId", "dbo.Kupecs");
            DropIndex("dbo.Račun", new[] { "KupecId" });
            AlterColumn("dbo.Račun", "KupecId", c => c.Int());
            RenameColumn(table: "dbo.Račun", name: "KupecId", newName: "Kupec_Id");
            CreateIndex("dbo.Račun", "Kupec_Id");
            AddForeignKey("dbo.Račun", "Kupec_Id", "dbo.Kupecs", "Id");
        }
    }
}
