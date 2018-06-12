using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameBot.Models
{
    public class Bot
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime StartBot { get; set; }
        public virtual Game Game { get; set; }
        public string GameID { get; set; }
        public bool IsStarted { get; set; }
    }
}