using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameBot.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Avatar { get; set; }
        public string Name { get; set; }
        public virtual ApplicationUser User { get; set; }
        public string ApplicationUserID { get; set; }
        public virtual ICollection<Bot> Bots { get; set; }
    }
}