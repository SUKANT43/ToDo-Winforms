using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Controller
{
    class AuthController
    {
        private static string email;
        public static void SetMail(string mailId)
        {
            email = mailId;
        }

        public static string GetMail()
        {
            return email;
        }
    }
}
