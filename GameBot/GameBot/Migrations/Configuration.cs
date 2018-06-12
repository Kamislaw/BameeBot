namespace GameBot.Migrations
{
    using GameBot.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GameBot.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "GameBot.Models.ApplicationDbContext";
        }

        protected override void Seed(GameBot.Models.ApplicationDbContext context)
        {
            //SeedGame(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }

        private void SeedGame(ApplicationDbContext context) {
            IList<Game> listOfGames = new List<Game> {
                new Game() { Name = "Wojna tytanow", Avatar = "http://i.iplsc.com/wojna-tytanow/0003H0K8Q94QFYIN-C116-F4.jpg"},
                new Game() { Name = "Gangsters", Avatar = "https://i.ytimg.com/vi/b4syyAiEt6o/maxresdefault.jpg" },
                };

            context.Games.AddRange(listOfGames);
            context.SaveChanges();
        }
    }
}
