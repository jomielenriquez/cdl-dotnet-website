using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            PortalDBEntities conn = new PortalDBEntities();
            Sample test = new Sample()
            {
                message = conn.TBL_ADMIN.Select(x => x.USERNAME).FirstOrDefault()
            };

            return View(test);
        }
    }
}