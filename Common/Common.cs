using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BookHaven.Common
{
    public static class Common
    {
        public static readonly string admin = "admin";
        public static readonly string cleark = "cleark";
        public static void goBack(Form currentForm, Form nextForm) {
            if (currentForm != null)
            {
                currentForm.Hide();
                nextForm.Show();
            }
        }

        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
