namespace GameBot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isStarted : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bots", "IsStarted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bots", "IsStarted");
        }
    }
}
