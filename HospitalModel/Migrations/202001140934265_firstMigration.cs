namespace HospitalModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PatientCards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FIO = c.String(),
                        InsuranceCompany = c.String(),
                        InsuranceNumber = c.String(),
                        Passport = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SicknessHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateReception = c.DateTime(nullable: false),
                        Complaints = c.String(),
                        Diagnosis = c.String(),
                        Temperature = c.String(),
                        Datedischarge = c.DateTime(nullable: false),
                        PatientCardId = c.Int(nullable: false),
                        RoomId = c.Int(nullable: false),
                        WorkerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PatientCards", t => t.PatientCardId, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .ForeignKey("dbo.Workers", t => t.WorkerId, cascadeDelete: true)
                .Index(t => t.PatientCardId)
                .Index(t => t.RoomId)
                .Index(t => t.WorkerId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        RoomNumber = c.Int(nullable: false),
                        Gender = c.String(),
                        Capacity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FIO = c.String(),
                        Role = c.String(),
                        Position = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Treatments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TotalAmount = c.Int(nullable: false),
                        DailyAmount = c.Int(nullable: false),
                        ServiceId = c.Int(nullable: false),
                        SicknessHistoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .ForeignKey("dbo.SicknessHistories", t => t.SicknessHistoryId, cascadeDelete: true)
                .Index(t => t.ServiceId)
                .Index(t => t.SicknessHistoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Treatments", "SicknessHistoryId", "dbo.SicknessHistories");
            DropForeignKey("dbo.Treatments", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.SicknessHistories", "WorkerId", "dbo.Workers");
            DropForeignKey("dbo.SicknessHistories", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.SicknessHistories", "PatientCardId", "dbo.PatientCards");
            DropIndex("dbo.Treatments", new[] { "SicknessHistoryId" });
            DropIndex("dbo.Treatments", new[] { "ServiceId" });
            DropIndex("dbo.SicknessHistories", new[] { "WorkerId" });
            DropIndex("dbo.SicknessHistories", new[] { "RoomId" });
            DropIndex("dbo.SicknessHistories", new[] { "PatientCardId" });
            DropTable("dbo.Treatments");
            DropTable("dbo.Services");
            DropTable("dbo.Workers");
            DropTable("dbo.Rooms");
            DropTable("dbo.SicknessHistories");
            DropTable("dbo.PatientCards");
        }
    }
}
