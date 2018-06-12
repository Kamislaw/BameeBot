namespace GameBot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BotModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bots",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        StartBot = c.DateTime(nullable: false),
                        GameID = c.String(),
                        Game_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Games", t => t.Game_Id)
                .Index(t => t.Game_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bots", "Game_Id", "dbo.Games");
            DropIndex("dbo.Bots", new[] { "Game_Id" });
            DropTable("dbo.Bots");
        }
    }
}
