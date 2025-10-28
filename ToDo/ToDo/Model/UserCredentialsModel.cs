using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Model
{
    class UserCredentialsModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }           
        public string ProfileImagePath { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
 