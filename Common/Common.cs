using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Common
{
    public static class Common
    {
        public static readonly string admin = "admin";
        public static readonly string cleark = "admin";
        public static void goBack(Form currentForm, Form nextForm) {
            if (currentForm != null)
            {
                currentForm.Hide();
                nextForm.Show();
            }
        }
    }
}
