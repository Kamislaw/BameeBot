using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameBot.Models
{
    public class BotViewModel
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        [DataType(DataType.Time)]
        [Display(Name = "When bot start?")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm:ss}")]
        public DateTime StartBot { get; set; }
        public string GameID { get; set; }
        public bool IsStarted { get; set; }
    }
}