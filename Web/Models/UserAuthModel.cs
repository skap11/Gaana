using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class UserAuthModel
    {
        public string Username { get; set; }
        private string password;

        public string Password
        {
            get { return password; }
        }
        
    }
}