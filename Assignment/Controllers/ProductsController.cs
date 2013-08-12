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

        public ActionResult Index(String filter, int page = 1) {
            // Initialize datacontext
            ElectonicShopDataContext db = new ElectonicShopDataContext();

            // Get category tree
            List<CategoryParent> catParents = (from t in db.CategoryParents
                                               select t).ToList();
            Dictionary<CategoryParent, List<Category>> categoryTree = new Dictionary<CategoryParent, List<Category>>();

            foreach (CategoryParent catParent in catParents) {
                List<Category> cats = (from c in db.Categories
                                       where c.CategoryParent.Equals(catParent)
                                       select c).ToList();

                categoryTree.Add(catParent, cats);
            }

            // Get list of products
			int defaultLimit = 16; // Configurable
            List<Product> products = (from p in db.Products
                                      select p).ToList();
			int countPages = products.Count() / defaultLimit + 1;
			page = (page < 1) ? 1 : page;
			page = (page > countPages) ? countPages : page;
			products = products.Skip((page - 1) * defaultLimit).Take(defaultLimit).ToList();

            ViewData["filter"] = filter;
            ViewData["categoryTree"] = categoryTree;
            ViewData["products"] = products;
			
			ViewData["page"] = page;
			ViewData["countPages"] = countPages;
            return View();
        }

    }
}
