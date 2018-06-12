using GameBot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameBot.Controllers
{
    public class BotController : Controller
    {
        // GET: Bot
        public ActionResult Index() {
            return View();
        }

        public ActionResult Start(BotViewModel vm) {

            var ctx = new ApplicationDbContext();
            var bot = new Bot {
                Id = vm.Id,
                Login = vm.Login,
                Password = vm.Password,
                StartBot = vm.StartBot,
                GameID = vm.GameID,
                IsStarted = true,

            };
            ctx.Entry(ctx.Bots.Where(x => x.Id == vm.Id).First()).CurrentValues.SetValues(bot);

            return View("BotSettings", "");
        }
    }
}