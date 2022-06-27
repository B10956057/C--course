using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B10956057_webapi.Models
{
    public class LoginUser
    {
        public string Account { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Role { get; set; }

        public bool IsDisable { get; set; }
    }
}
