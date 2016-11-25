using System.Web.Mvc;

namespace KhachSan.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin",
                "Admin/{controller}/{action}/{id}",
<<<<<<< HEAD
                new { action = "Index",controller="Login", id = UrlParameter.Optional }
=======
                new { Controller = "HomeAdmin",action = "Index",id = UrlParameter.Optional }
>>>>>>> 286e2baa5372cf4d5bd3f9167dcdcbddb9af3970
            );
        }
    }
}