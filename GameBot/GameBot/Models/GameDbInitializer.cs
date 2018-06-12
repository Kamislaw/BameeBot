using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GameBot.Models
{
    public class GameDbInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context) {
            IList<Game> listOfGames = new List<Game> {
                new Game() { Name = "Wojna tytanow", Avatar = "~/Images/WojnaTytanow.jpg"},
                new Game() { Name = "Gangsters", Avatar = "~/Images/gangsters.jpg" },
                };

            context.Games.AddRange(listOfGames);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}