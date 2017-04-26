namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Virtual : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Inspections", name: "AddressId", newName: "Address_Id");
            RenameColumn(table: "dbo.Inspections", name: "InspectorId", newName: "Inspector_Id");
            RenameIndex(table: "dbo.Inspections", name: "IX_AddressId", newName: "IX_Address_Id");
            RenameIndex(table: "dbo.Inspections", name: "IX_InspectorId", newName: "IX_Inspector_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Inspections", name: "IX_Inspector_Id", newName: "IX_InspectorId");
            RenameIndex(table: "dbo.Inspections", name: "IX_Address_Id", newName: "IX_AddressId");
            RenameColumn(table: "dbo.Inspections", name: "Inspector_Id", newName: "InspectorId");
            RenameColumn(table: "dbo.Inspections", name: "Address_Id", newName: "AddressId");
        }
    }
}
