namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StringLength1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Inspections", "Date", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Inspections", "TimeIn", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Inspections", "TimeOut", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Inspections", "TimeOut", c => c.String(nullable: false));
            AlterColumn("dbo.Inspections", "TimeIn", c => c.String(nullable: false));
            AlterColumn("dbo.Inspections", "Date", c => c.String(nullable: false));
        }
    }
}
