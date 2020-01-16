namespace HospitalModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addIsTreatedNowBoolToPatientCard : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientCards", "IsTreatedNow", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PatientCards", "IsTreatedNow");
        }
    }
}
