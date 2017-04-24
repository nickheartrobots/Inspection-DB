namespace WebAPI.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateAddresses : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Addresses ON");
            Sql("INSERT INTO Addresses (Id, StreetAddress1, StreetAddress2, City, State, Zip) VALUES (1, '5332 Knox Ave N', '', 'Brooklyn Center', 'MN', '55430')");
            Sql("INSERT INTO Addresses (Id, StreetAddress1, StreetAddress2, City, State, Zip) VALUES (2, '3412 Woodbine Ln', '', 'Brooklyn Center', 'MN', '55429')");
            Sql("INSERT INTO Addresses (Id, StreetAddress1, StreetAddress2, City, State, Zip) VALUES (3, '5050 Russell Ave N', '', 'Minneapolis', 'MN', '55430')");
            Sql("SET IDENTITY_INSERT Addresses OFF");
        }

        public override void Down()
        {
            Sql("DELETE FROM Addresses WHERE Id IN (1, 2, 3)");
        }
    }
}
