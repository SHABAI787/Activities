namespace VActivities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Num = c.Int(nullable: false),
                        Name = c.String(),
                        DateIn = c.DateTime(),
                        DateOut = c.DateTime(),
                        Customer = c.String(),
                        RegNum = c.String(),
                        RegNumIn = c.String(),
                        Result = c.String(),
                        Feedback = c.String(),
                        DatеCreated = c.DateTime(nullable: false),
                        BasisСonducting_Id = c.Int(),
                        Executor_Id = c.Int(),
                        InformationObject_Id = c.Int(),
                        Purpose_Id = c.Int(),
                        Responsible_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BasisСonducting", t => t.BasisСonducting_Id)
                .ForeignKey("dbo.Person", t => t.Executor_Id)
                .ForeignKey("dbo.InformationObject", t => t.InformationObject_Id)
                .ForeignKey("dbo.Purpose", t => t.Purpose_Id)
                .ForeignKey("dbo.Person", t => t.Responsible_Id)
                .Index(t => t.BasisСonducting_Id)
                .Index(t => t.Executor_Id)
                .Index(t => t.InformationObject_Id)
                .Index(t => t.Purpose_Id)
                .Index(t => t.Responsible_Id);
            
            CreateTable(
                "dbo.BasisСonducting",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Surname = c.String(),
                        Name = c.String(),
                        MiddleName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.InformationObject",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Num = c.String(),
                        IMEI = c.String(),
                        IMSI = c.String(),
                        DatеCreated = c.DateTime(nullable: false),
                        DatеUpdated = c.DateTime(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Purpose",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.History",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DatеCreated = c.DateTime(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        User_Login = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.User_Login)
                .Index(t => t.User_Login);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Login = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                        Active = c.Boolean(nullable: false),
                        DatеCreated = c.DateTime(nullable: false),
                        DatеUpdated = c.DateTime(),
                        Data = c.String(),
                        Person_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Login)
                .ForeignKey("dbo.Person", t => t.Person_Id)
                .Index(t => t.Person_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.History", "User_Login", "dbo.User");
            DropForeignKey("dbo.User", "Person_Id", "dbo.Person");
            DropForeignKey("dbo.Activities", "Responsible_Id", "dbo.Person");
            DropForeignKey("dbo.Activities", "Purpose_Id", "dbo.Purpose");
            DropForeignKey("dbo.Activities", "InformationObject_Id", "dbo.InformationObject");
            DropForeignKey("dbo.Activities", "Executor_Id", "dbo.Person");
            DropForeignKey("dbo.Activities", "BasisСonducting_Id", "dbo.BasisСonducting");
            DropIndex("dbo.User", new[] { "Person_Id" });
            DropIndex("dbo.History", new[] { "User_Login" });
            DropIndex("dbo.Activities", new[] { "Responsible_Id" });
            DropIndex("dbo.Activities", new[] { "Purpose_Id" });
            DropIndex("dbo.Activities", new[] { "InformationObject_Id" });
            DropIndex("dbo.Activities", new[] { "Executor_Id" });
            DropIndex("dbo.Activities", new[] { "BasisСonducting_Id" });
            DropTable("dbo.User");
            DropTable("dbo.History");
            DropTable("dbo.Purpose");
            DropTable("dbo.InformationObject");
            DropTable("dbo.Person");
            DropTable("dbo.BasisСonducting");
            DropTable("dbo.Activities");
        }
    }
}
