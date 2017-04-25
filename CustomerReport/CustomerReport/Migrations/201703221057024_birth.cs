namespace CustomerReport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class birth : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "DOB", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "DOB", c => c.Int(nullable: false));
        }
    }
}
