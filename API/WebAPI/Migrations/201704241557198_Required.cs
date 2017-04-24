namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Required : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Inspections", "Address_Id", "dbo.Addresses");
            DropForeignKey("dbo.Inspections", "Inspector_Id", "dbo.Inspectors");
            DropIndex("dbo.Inspections", new[] { "Address_Id" });
            DropIndex("dbo.Inspections", new[] { "Inspector_Id" });
            AlterColumn("dbo.Addresses", "StreetAddress1", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Addresses", "StreetAddress2", c => c.String(maxLength: 255));
            AlterColumn("dbo.Addresses", "City", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Addresses", "State", c => c.String(nullable: false, maxLength: 2));
            AlterColumn("dbo.Addresses", "Zip", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Inspections", "Address_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Inspections", "Inspector_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Inspectors", "InspectorLastName", c => c.String(nullable: false));
            AlterColumn("dbo.Inspectors", "InspectorFirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Inspectors", "InspectorNumber", c => c.String(nullable: false));
            CreateIndex("dbo.Inspections", "Address_Id");
            CreateIndex("dbo.Inspections", "Inspector_Id");
            AddForeignKey("dbo.Inspections", "Address_Id", "dbo.Addresses", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Inspections", "Inspector_Id", "dbo.Inspectors", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inspections", "Inspector_Id", "dbo.Inspectors");
            DropForeignKey("dbo.Inspections", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.Inspections", new[] { "Inspector_Id" });
            DropIndex("dbo.Inspections", new[] { "Address_Id" });
            AlterColumn("dbo.Inspectors", "InspectorNumber", c => c.String());
            AlterColumn("dbo.Inspectors", "InspectorFirstName", c => c.String());
            AlterColumn("dbo.Inspectors", "InspectorLastName", c => c.String());
            AlterColumn("dbo.Inspections", "Inspector_Id", c => c.Int());
            AlterColumn("dbo.Inspections", "Address_Id", c => c.Int());
            AlterColumn("dbo.Addresses", "Zip", c => c.String());
            AlterColumn("dbo.Addresses", "State", c => c.String());
            AlterColumn("dbo.Addresses", "City", c => c.String());
            AlterColumn("dbo.Addresses", "StreetAddress2", c => c.String());
            AlterColumn("dbo.Addresses", "StreetAddress1", c => c.String());
            CreateIndex("dbo.Inspections", "Inspector_Id");
            CreateIndex("dbo.Inspections", "Address_Id");
            AddForeignKey("dbo.Inspections", "Inspector_Id", "dbo.Inspectors", "Id");
            AddForeignKey("dbo.Inspections", "Address_Id", "dbo.Addresses", "Id");
        }
    }
}
