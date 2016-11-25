using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KhachSan.Areas.Admin.Code
{
    public class SessionHelper
    {
        public static void set_Session(UserSession session)
        {
            HttpContext.Current.Session["loginSession"] = session;

        }
        public static UserSession get_Session()
        {
            var session = HttpContext.Current.Session["loginSession"];
            if (session==null)
            {
                return null;
            }
            else
            {
                return session as UserSession;
            }
        }
    }
}