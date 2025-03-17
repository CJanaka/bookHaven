using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Common
{
    public static class SessionManager
    {
        public static string CurrentRole { get; set; }
        public static int CurrentUserId { get; set; }
        public static string CurrentUsername { get; set; }
        public static bool IsLoggedIn { get; set; }

        
        public static void ClearSession()
        {
            CurrentRole = null;
            CurrentUsername = null;
        }
    }
}
