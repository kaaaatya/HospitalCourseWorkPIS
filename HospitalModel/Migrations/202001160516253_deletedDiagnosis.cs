namespace HospitalModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedDiagnosis : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SicknessHistories", "Diagnosis");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SicknessHistories", "Diagnosis", c => c.String());
        }
    }
}
