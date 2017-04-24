namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Inspections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.String(),
                        AddressId = c.Int(nullable: false),
                        TimeIn = c.String(),
                        TimeOut = c.String(),
                        Inspector_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.AddressId, cascadeDelete: true)
                .ForeignKey("dbo.Inspectors", t => t.Inspector_Id)
                .Index(t => t.AddressId)
                .Index(t => t.Inspector_Id);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StreetAddress1 = c.String(),
                        StreetAddress2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Inspectors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InspectorLastName = c.String(),
                        InspectorFirstName = c.String(),
                        InspectorNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inspections", "Inspector_Id", "dbo.Inspectors");
            DropForeignKey("dbo.Inspections", "AddressId", "dbo.Addresses");
            DropIndex("dbo.Inspections", new[] { "Inspector_Id" });
            DropIndex("dbo.Inspections", new[] { "AddressId" });
            DropTable("dbo.Inspectors");
            DropTable("dbo.Addresses");
            DropTable("dbo.Inspections");
        }
    }
}
