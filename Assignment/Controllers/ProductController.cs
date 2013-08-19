using MvcAssignment.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAssignment.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        public ActionResult Index(int id = 0)
        {
			// Initialize datacontext
			ElectonicShopDataContext db = new ElectonicShopDataContext();

			Product product = (from p in db.Products
							   where p.id == id
							   select p).FirstOrDefault();

			if (product == null) {
				return RedirectToAction("Index", "Products", null);
			}

			ViewData["product"] = product;

            return View();
        }

    }
}
