namespace SIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JobPostTable2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JobPosts", "obCode", c => c.String(nullable: false, maxLength: 5));
            DropColumn("dbo.JobPosts", "JobCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.JobPosts", "JobCode", c => c.String(nullable: false, maxLength: 5));
            DropColumn("dbo.JobPosts", "obCode");
        }
    }
}
