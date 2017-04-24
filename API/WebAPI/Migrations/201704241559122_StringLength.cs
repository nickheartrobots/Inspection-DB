namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StringLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Inspectors", "InspectorLastName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Inspectors", "InspectorFirstName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Inspectors", "InspectorNumber", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Inspectors", "InspectorNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Inspectors", "InspectorFirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Inspectors", "InspectorLastName", c => c.String(nullable: false));
        }
    }
}
