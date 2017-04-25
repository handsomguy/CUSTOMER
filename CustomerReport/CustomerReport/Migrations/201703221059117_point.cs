namespace CustomerReport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class point : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Points", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Points", c => c.Int(nullable: false));
        }
    }
}
