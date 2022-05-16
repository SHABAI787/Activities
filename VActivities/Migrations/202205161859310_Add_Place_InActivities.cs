namespace VActivities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Place_InActivities : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Activities", "Place", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Activities", "Place");
        }
    }
}
