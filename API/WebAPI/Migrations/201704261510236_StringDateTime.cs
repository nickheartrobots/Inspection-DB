namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StringDateTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Inspections", "Date", c => c.String(nullable: false));
            AlterColumn("dbo.Inspections", "TimeIn", c => c.String(nullable: false));
            AlterColumn("dbo.Inspections", "TimeOut", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Inspections", "TimeOut", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Inspections", "TimeIn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Inspections", "Date", c => c.DateTime(nullable: false));
        }
    }
}
