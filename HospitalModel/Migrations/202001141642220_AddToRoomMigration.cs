namespace HospitalModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddToRoomMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rooms", "Available", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rooms", "Available");
        }
    }
}
