namespace may222017.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class placeStatusmigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Places", "status", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Places", "status");
        }
    }
}
