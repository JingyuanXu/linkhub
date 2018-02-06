using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL;

namespace UI.Areas.User.Controllers
{
    public class URLController : Controller
    {
        // GET: User/URL
        public ActionResult Index()
        {
            LinkHubDbEntities db=new LinkHubDbEntities();
            ViewBag.CategoryId = new SelectList(db.tbl_Category, "CategoryId", "CategoryName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(tbl_Url objUrl)
        {
            
            return View();
        }
    }
}