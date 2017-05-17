namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VehicleStuff : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Vehicles");
            AddColumn("dbo.Vehicles", "Vin", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.Vehicles", "DecalNumber", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.Vehicles", "LicenseState", c => c.String(nullable: false, maxLength: 2));
            AddColumn("dbo.Vehicles", "Odometer", c => c.Single(nullable: false));
            AddColumn("dbo.Vehicles", "UnitNumber", c => c.String(maxLength: 255));
            AddPrimaryKey("dbo.Vehicles", "Vin");
            DropColumn("dbo.Vehicles", "Id");
            DropColumn("dbo.Vehicles", "Decal");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vehicles", "Decal", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.Vehicles", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Vehicles");
            DropColumn("dbo.Vehicles", "UnitNumber");
            DropColumn("dbo.Vehicles", "Odometer");
            DropColumn("dbo.Vehicles", "LicenseState");
            DropColumn("dbo.Vehicles", "DecalNumber");
            DropColumn("dbo.Vehicles", "Vin");
            AddPrimaryKey("dbo.Vehicles", "Id");
        }
    }
}
