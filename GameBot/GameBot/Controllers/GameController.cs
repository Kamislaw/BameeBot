using GameBot.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameBot.Controllers
{
    public class GameController : Controller
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        private ApplicationGameManager _gameManager;
        public GameController() {
        }

        public GameController(ApplicationUserManager userManager, ApplicationSignInManager signInManager) {
            UserManager = userManager;
            SignInManager = signInManager;
            _gameManager = new ApplicationGameManager();
        }
        public ApplicationSignInManager SignInManager {
            get {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager {
            get {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set {
                _userManager = value;
            }
        }
        // GET: Game
        [Authorize]
        public ActionResult Index() {
            var ctx = new ApplicationDbContext();
            var userId = User.Identity.GetUserId();
            //var workouts = ctx.Games.Where(x => x.ApplicationUserID == userId).ToList();
            var model = ctx.Games.Select(x => new GameViewModel {
                Id = x.Id,
                Avatar = x.Avatar,
                Name = x.Name,
            });
            return View(model);
        }
        [Authorize]
        public ActionResult BotSettings() {
            return View(new BotViewModel());
            //return PartialView(@"~/Views/Game/_ListOfSettingsPartial.cshtml");
        }
        [Authorize]
        [HttpPost]
        public ActionResult BotSettings(BotViewModel botvm, string id) {
            var ctx = new ApplicationDbContext();
            IEnumerable<Bot> bots = new List<Bot>();

            var bot = new Bot() {
                Login = botvm.Login,
                Password = botvm.Password,
                StartBot = botvm.StartBot,
                GameID = id,
            };
            ctx.Bots.Add(bot);
            ctx.SaveChanges();

            return View();
            //return PartialView(@"~/Views/Game/_ListOfSettingsPartial.cshtml");

        }
        public ActionResult GetListOfSettings() {
            var ctx = new ApplicationDbContext();

            var model = ctx.Bots.Select(x => new BotViewModel {
                Id = x.Id,
                Login = x.Login,
                Password = x.Password,
                StartBot = x.StartBot,
            });

            return PartialView("_ListOfSettingsPartial", model);
        }
        
    }
}