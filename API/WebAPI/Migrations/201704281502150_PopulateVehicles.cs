namespace WebAPI.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateVehicles : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Vehicles ON");
            Sql("INSERT INTO Vehicles (Id, Decal, Make, Year, License) VALUES (1, '1234', 'Ford', 2012, '123-ABC')");
            Sql("INSERT INTO Vehicles (Id, Decal, Make, Year, License) VALUES (2, '9876', 'Subaru', 2017, '333-DEF')");
            Sql("INSERT INTO Vehicles (Id, Decal, Make, Year, License) VALUES (3, '1234', 'Toyota', 2015, '987-CAR')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Vehicles WHERE Id IN (1, 2, 3)");
        }
    }
}
