using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGrease.Css.Ast.Selectors;
using WebApplicationRRPortal.UsersModels;

namespace WebApplicationRRPortal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public void Test(string idUser_personal_info) {

            
        //var test = from pa in

            var query = from u in UsersModels
                        where u.idUser_personal_info == idUser_personal_info
                        select u;
            Console.WriteLine(query);

        }
        
    }

}