using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ajax.Models
{
    public class User
    {
        [Key]
        public string Username { set; get; }
        public string Password { set; get; }
        public string Fullname { set; get; }
        public string Gender { set; get; }
    }
    
}