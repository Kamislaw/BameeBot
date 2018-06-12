using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameBot.Models
{
    public class GameViewModel
    {
        public int Id { get; set; }
        public string Avatar { get; set; }
        public string Name { get; set; }
        public string ApplicationUserID { get; set; }
    }
}