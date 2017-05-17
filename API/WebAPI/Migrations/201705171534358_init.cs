namespace WebAPI.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    StreetAddress1 = c.String(nullable: false, maxLength: 255),
                    StreetAddress2 = c.String(maxLength: 255),
                    City = c.String(nullable: false, maxLength: 255),
                    State = c.String(nullable: false, maxLength: 2),
                    Zip = c.String(nullable: false, maxLength: 10),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Inspections",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Date = c.String(nullable: false, maxLength: 255),
                    TimeIn = c.String(nullable: false, maxLength: 255),
                    TimeOut = c.String(nullable: false, maxLength: 255),
                    Address_Id = c.Int(nullable: false),
                    Inspector_Id = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.Address_Id, cascadeDelete: true)
                .ForeignKey("dbo.Inspectors", t => t.Inspector_Id, cascadeDelete: true)
                .Index(t => t.Address_Id)
                .Index(t => t.Inspector_Id);

            CreateTable(
                "dbo.Inspectors",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    LastName = c.String(nullable: false, maxLength: 255),
                    FirstName = c.String(nullable: false, maxLength: 255),
                    Number = c.String(nullable: false, maxLength: 255),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.AspNetRoles",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Name = c.String(nullable: false, maxLength: 256),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");

            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                {
                    UserId = c.String(nullable: false, maxLength: 128),
                    RoleId = c.String(nullable: false, maxLength: 128),
                })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);

            CreateTable(
                "dbo.AspNetUsers",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Email = c.String(maxLength: 256),
                    EmailConfirmed = c.Boolean(nullable: false),
                    PasswordHash = c.String(),
                    SecurityStamp = c.String(),
                    PhoneNumber = c.String(),
                    PhoneNumberConfirmed = c.Boolean(nullable: false),
                    TwoFactorEnabled = c.Boolean(nullable: false),
                    LockoutEndDateUtc = c.DateTime(),
                    LockoutEnabled = c.Boolean(nullable: false),
                    AccessFailedCount = c.Int(nullable: false),
                    UserName = c.String(nullable: false, maxLength: 256),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");

            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    UserId = c.String(nullable: false, maxLength: 128),
                    ClaimType = c.String(),
                    ClaimValue = c.String(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);

            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                {
                    LoginProvider = c.String(nullable: false, maxLength: 128),
                    ProviderKey = c.String(nullable: false, maxLength: 128),
                    UserId = c.String(nullable: false, maxLength: 128),
                })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);

            CreateTable(
                "dbo.Vehicles",
                c => new
                {
                    Vin = c.String(nullable: false, maxLength: 255),
                    DecalNumber = c.String(nullable: false, maxLength: 255),
                    Make = c.String(nullable: false, maxLength: 255),
                    Year = c.Int(nullable: false),
                    License = c.String(nullable: false, maxLength: 255),
                    LicenseState = c.String(nullable: false, maxLength: 2),
                    Odometer = c.Single(nullable: false),
                    UnitNumber = c.String(maxLength: 255),
                })
                .PrimaryKey(t => t.Vin);

        }

        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Inspections", "Inspector_Id", "dbo.Inspectors");
            DropForeignKey("dbo.Inspections", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Inspections", new[] { "Inspector_Id" });
            DropIndex("dbo.Inspections", new[] { "Address_Id" });
            DropTable("dbo.Vehicles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Inspectors");
            DropTable("dbo.Inspections");
            DropTable("dbo.Addresses");
        }
    }
}
