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

			// Manipulate product filter conditions
			String currentBinState = "";
			try {
				currentBinState = Convert.ToString(Convert.ToInt32(filter, 16), 2).PadLeft(64, '0');
			} catch (Exception) {
				currentBinState = "".PadLeft(64, '0');
			}

			List<int> filterCategories = new List<int>();

			int index = 1;
			foreach (KeyValuePair<CategoryParent, List<Category>> cp in categoryTree) {
				foreach (Category c in cp.Value) {
					if (currentBinState[currentBinState.Length - index] - 48 == 1) {
						filterCategories.Add(c.id);
					}
					index++;
				}
			}

			// Get list of products
			int defaultLimit = 16; // Configurable

			List<Product> products = (from p in db.Products
									  select p).ToList();
			if (filterCategories.Count > 0) {
				var a = (from p in db.Products
						 join cd in db.CategoryDetails on p equals cd.Product
						 where filterCategories.Contains(cd.category_id)
						 select p);
				products = a.ToList();
			}

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
