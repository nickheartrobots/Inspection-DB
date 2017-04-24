namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeInspectorColNames : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Inspectors", "LastName", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.Inspectors", "FirstName", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.Inspectors", "Number", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Inspectors", "InspectorLastName");
            DropColumn("dbo.Inspectors", "InspectorFirstName");
            DropColumn("dbo.Inspectors", "InspectorNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Inspectors", "InspectorNumber", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.Inspectors", "InspectorFirstName", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.Inspectors", "InspectorLastName", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Inspectors", "Number");
            DropColumn("dbo.Inspectors", "FirstName");
            DropColumn("dbo.Inspectors", "LastName");
        }
    }
}
