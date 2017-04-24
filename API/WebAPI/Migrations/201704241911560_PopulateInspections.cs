namespace WebAPI.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateInspections : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Inspections ON");
            Sql("INSERT INTO Inspections (Id, Date, AddressId, TimeIn, TimeOut, InspectorId) VALUES (1, '20170424 10:34:00 AM', 1, '20170424 10:34:00 AM', '20170424 11:15:00 AM', 1)");
            Sql("SET IDENTITY_INSERT Inspections OFF");
        }

        public override void Down()
        {
            Sql("DELETE FROM Inspections WHERE Id IN (1)");
        }
    }
}
