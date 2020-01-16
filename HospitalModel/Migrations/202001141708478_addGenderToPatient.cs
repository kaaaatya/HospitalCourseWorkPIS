namespace HospitalModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGenderToPatient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientCards", "Gender", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PatientCards", "Gender");
        }
    }
}
