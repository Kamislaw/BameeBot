namespace GameBot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GameModelChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "ApplicationUserID", c => c.String(maxLength: 128));
            CreateIndex("dbo.Games", "ApplicationUserID");
            AddForeignKey("dbo.Games", "ApplicationUserID", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "ApplicationUserID", "dbo.AspNetUsers");
            DropIndex("dbo.Games", new[] { "ApplicationUserID" });
            DropColumn("dbo.Games", "ApplicationUserID");
        }
    }
}
