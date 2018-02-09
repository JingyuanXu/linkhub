using BLL;
using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Areas.Admin.Controllers
{
    //[Authorize(Roles="A")]
    public class CategoryController : BaseAdminController
    {
          
        //
        // GET: /Admin/Category/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(tbl_Category category)
        {
            try
            {
                //from BOL->LinkHubModel.edmx->LinkHubModel.tt->tbl_category.cs add [Required] OR tblUserValidation.cs
                if (ModelState.IsValid)
                {
                    objBs.categoryBs.Insert(category);
                    TempData["Msg"] = "Created Successfully";
                    return RedirectToAction("Index");
                }
                else
                {
                    return View("Index");
                }
            }
            catch (Exception e1)
            {
                TempData["Msg"] = "Create Failed : " + e1.Message;
                return RedirectToAction("Index");
            }
        }
	}
}