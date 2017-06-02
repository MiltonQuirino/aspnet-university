namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Schedule",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Tipo = c.String(),
                        Start = c.String(nullable: false),
                        End = c.String(nullable: false),
                        Day = c.String(nullable: false),
                        Student_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Student", t => t.Student_ID)
                .Index(t => t.Student_ID);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Class = c.String(nullable: false, maxLength: 50),
                        Team = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schedule", "Student_ID", "dbo.Student");
            DropIndex("dbo.Schedule", new[] { "Student_ID" });
            DropTable("dbo.Student");
            DropTable("dbo.Schedule");
        }
    }
}
