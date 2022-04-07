namespace TeamMVCProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Modules",
                c => new
                    {
                        ModuleID = c.Int(nullable: false, identity: true),
                        CourseID = c.Int(nullable: false),
                        ModuleCode = c.String(),
                        ModuleTitle = c.String(),
                        ModuleDescription = c.String(),
                        ModuleContents = c.String(),
                    })
                .PrimaryKey(t => t.ModuleID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Modules");
        }
    }
}
