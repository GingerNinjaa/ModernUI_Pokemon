namespace ModernUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Edit : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblCategories", "CategoryName", c => c.String(maxLength: 50));
            AlterColumn("dbo.tblProducts", "Name", c => c.String(maxLength: 150));
            AlterColumn("dbo.tblProducts", "Description", c => c.String(maxLength: 500));
            AlterColumn("dbo.tblProducts", "CategoryName", c => c.String(maxLength: 150));
            AlterColumn("dbo.tblUserRoles", "RoleName", c => c.String(maxLength: 50));
            AlterColumn("dbo.tblUsers", "FirstName", c => c.String(maxLength: 50));
            AlterColumn("dbo.tblUsers", "LastName", c => c.String(maxLength: 100));
            AlterColumn("dbo.tblUsers", "Email", c => c.String(maxLength: 100));
            AlterColumn("dbo.tblUsers", "Position", c => c.String(maxLength: 50));
            AlterColumn("dbo.tblUsers", "UserName", c => c.String(maxLength: 50));
            AlterColumn("dbo.tblUsers", "Password", c => c.String(maxLength: 50));
            AlterColumn("dbo.tblUsers", "Role", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblUsers", "Role", c => c.String());
            AlterColumn("dbo.tblUsers", "Password", c => c.String());
            AlterColumn("dbo.tblUsers", "UserName", c => c.String());
            AlterColumn("dbo.tblUsers", "Position", c => c.String());
            AlterColumn("dbo.tblUsers", "Email", c => c.String());
            AlterColumn("dbo.tblUsers", "LastName", c => c.String());
            AlterColumn("dbo.tblUsers", "FirstName", c => c.String());
            AlterColumn("dbo.tblUserRoles", "RoleName", c => c.String());
            AlterColumn("dbo.tblProducts", "CategoryName", c => c.String());
            AlterColumn("dbo.tblProducts", "Description", c => c.String());
            AlterColumn("dbo.tblProducts", "Name", c => c.String());
            AlterColumn("dbo.tblCategories", "CategoryName", c => c.String());
        }
    }
}
