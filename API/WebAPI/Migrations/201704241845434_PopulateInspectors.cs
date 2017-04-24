namespace WebAPI.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateInspectors : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Inspectors ON");
            Sql("INSERT INTO Inspectors (Id, InspectorLastName, InspectorFirstName, InspectorNumber) VALUES (1, 'Yang', 'Doua', '12-9999-17')");
            Sql("INSERT INTO Inspectors (Id, InspectorLastName, InspectorFirstName, InspectorNumber) VALUES (2, 'Clarity', 'Nick', '12-1234-16')");
            Sql("SET IDENTITY_INSERT Inspectors OFF");
        }

        public override void Down()
        {
            Sql("DELETE FROM Inspectors WHERE Id IN (1, 2)");
        }
    }
}
