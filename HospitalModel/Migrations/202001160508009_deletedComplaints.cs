namespace HospitalModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedComplaints : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SicknessHistories", "Complaints");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SicknessHistories", "Complaints", c => c.String());
        }
    }
}
