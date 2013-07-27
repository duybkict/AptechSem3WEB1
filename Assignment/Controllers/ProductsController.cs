using MvcAssignment.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAssignment.Controllers
{
    public class ProductsController : Controller
    {
        //
        // GET: /Products/

        public ActionResult Index() {
			ElectonicShopDataContext db = new ElectonicShopDataContext();
			List<CategoryParent> catParents = (from t in db.CategoryParents
							   select t).ToList();
			Dictionary<CategoryParent, List<Category>> categoryTree = new Dictionary<CategoryParent, List<Category>>();

			foreach (CategoryParent catParent in catParents) { 
				List<Category> cats = (from c in db.Categories
									   where c.CategoryParent.Equals(catParent)
									   select c).ToList();

				categoryTree.Add(catParent, cats);
			}

			ViewData["categoryTree"] = categoryTree;
            return View();
        }

    }
}
