namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateInspectionModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Inspections", "AddressId", "dbo.Addresses");
            DropIndex("dbo.Inspections", new[] { "AddressId" });
            RenameColumn(table: "dbo.Inspections", name: "AddressId", newName: "Address_Id");
            AlterColumn("dbo.Inspections", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Inspections", "Address_Id", c => c.Int());
            AlterColumn("dbo.Inspections", "TimeIn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Inspections", "TimeOut", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Inspections", "Address_Id");
            AddForeignKey("dbo.Inspections", "Address_Id", "dbo.Addresses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inspections", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.Inspections", new[] { "Address_Id" });
            AlterColumn("dbo.Inspections", "TimeOut", c => c.String());
            AlterColumn("dbo.Inspections", "TimeIn", c => c.String());
            AlterColumn("dbo.Inspections", "Address_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Inspections", "Date", c => c.String());
            RenameColumn(table: "dbo.Inspections", name: "Address_Id", newName: "AddressId");
            CreateIndex("dbo.Inspections", "AddressId");
            AddForeignKey("dbo.Inspections", "AddressId", "dbo.Addresses", "Id", cascadeDelete: true);
        }
    }
}
