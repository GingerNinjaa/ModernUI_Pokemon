namespace ModernUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKey_Test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblUsers", "RoleID", c => c.Int(nullable: false));
            CreateIndex("dbo.tblUsers", "RoleID");
            AddForeignKey("dbo.tblUsers", "RoleID", "dbo.tblUserRoles", "RoleId", cascadeDelete: true);
            DropColumn("dbo.tblUsers", "Role");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblUsers", "Role", c => c.String(maxLength: 50));
            DropForeignKey("dbo.tblUsers", "RoleID", "dbo.tblUserRoles");
            DropIndex("dbo.tblUsers", new[] { "RoleID" });
            DropColumn("dbo.tblUsers", "RoleID");
        }
    }
}
