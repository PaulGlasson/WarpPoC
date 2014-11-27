namespace Warp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoleConstraints : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Roles", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Roles", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Roles", "Description", c => c.String());
            AlterColumn("dbo.Roles", "Name", c => c.String());
        }
    }
}
