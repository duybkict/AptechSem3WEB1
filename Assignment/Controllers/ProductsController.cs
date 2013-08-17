using MvcAssignment.Linq;
using MvcAssignment.Models;
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

			List<List<int>> filterCategories = new List<List<int>>();

			int index = 1;
			foreach (KeyValuePair<CategoryParent, List<Category>> cp in categoryTree) {
				List<int> filterC = new List<int>();

				foreach (Category c in cp.Value) {
					if (currentBinState[currentBinState.Length - index] - 48 == 1) {
						filterC.Add(c.id);
					}
					index++;
				}

				if (filterC.Count > 0) {
					filterCategories.Add(filterC);
				}
			}

			// Get list of products
			int defaultLimit = 16; // Configurable

			List<Product> products = (from p in db.Products
									  select p).ToList();
			if (filterCategories.Count > 0) {
				foreach (List<int> filterC in filterCategories) {
					products = (from p in products
								join cd in db.CategoryDetails on p equals cd.Product
								where filterC.Contains(cd.category_id)
								select p).ToList();
				}
			}

			int countPages = products.Count() / defaultLimit + 1;
			page = (page < 1) ? 1 : page;
			page = (page > countPages) ? countPages : page;
			products = products.Skip((page - 1) * defaultLimit).Take(defaultLimit).ToList();

			// Shopping cart
			List<ShoppingCartItem> shoppingCart;
			if (Session["shoppingCart"] == null) {
				shoppingCart = new List<ShoppingCartItem>();
			} else {
				shoppingCart = (List<ShoppingCartItem>)Session["shoppingCart"];
			}
			int countCart = 0;
			foreach (ShoppingCartItem ci in shoppingCart) {
				countCart += ci.quantity;
			}

			ViewData["filter"] = filter;
			ViewData["categoryTree"] = categoryTree;
			ViewData["products"] = products;

			ViewData["page"] = page;
			ViewData["countPages"] = countPages;

			ViewData["shoppingCartCount"] = countCart;
			return View();
		}

		/**
		 * Count shopping cart items.
		 * @return		Number of items in shopping cart.
		 */
		public ActionResult CountCart() {
			// Load shopping cart from session
			List<ShoppingCartItem> shoppingCart;
			if (Session["shoppingCart"] == null) {
				shoppingCart = new List<ShoppingCartItem>();
			} else {
				shoppingCart = (List<ShoppingCartItem>)Session["shoppingCart"];
			}

			int count = 0;
			foreach (ShoppingCartItem ci in shoppingCart) {
				count += ci.quantity;
			}

			return Json(count, JsonRequestBehavior.AllowGet);
		}

		/**
		 * Show shopping cart.
		 * @return		Partial HTML view of the shopping cart.
		 */
		public ActionResult ShowCart() {
			// Load shopping cart from session
			List<ShoppingCartItem> shoppingCart;
			if (Session["shoppingCart"] == null) {
				shoppingCart = new List<ShoppingCartItem>();
			} else {
				shoppingCart = (List<ShoppingCartItem>)Session["shoppingCart"];
			}			

			return PartialView("_PartialShoppingCart", shoppingCart);
		}

		/**
		 * Add a product to shopping cart.
		 * @param int	Product id.
		 * @return		Partial HTML view of the shopping cart.
		 */
		public ActionResult AddToCart(int id) {
			// Initialize datacontext
			ElectonicShopDataContext db = new ElectonicShopDataContext();
			var product = (from p in db.Products
						   where p.id == id
						   select p).FirstOrDefault();

			// Load shopping cart from session
			List<ShoppingCartItem> shoppingCart;
			if (Session["shoppingCart"] == null) {
				shoppingCart = new List<ShoppingCartItem>();
			} else {
				shoppingCart = (List<ShoppingCartItem>)Session["shoppingCart"];
			}

			bool exist = false;
			foreach (ShoppingCartItem ci in shoppingCart) {
				if (ci.isKindOf(product)) {
					ci.quantity = ci.quantity + 1;
					exist = true;
					break;
				}
			}

			if (!exist) {
				shoppingCart.Add(new ShoppingCartItem(product));
			}

			// Save shopping cart
			Session["shoppingCart"] = shoppingCart;

			return PartialView("_PartialShoppingCart", shoppingCart);
		}

		/**
		 * Remove item from shopping cart.
		 * @param int	Product id.
		 * @return		Partial HTML view of the shopping cart.
		 */
		public ActionResult RemoveFromCart(int id) {
			// Load shopping cart from session
			List<ShoppingCartItem> shoppingCart;
			if (Session["shoppingCart"] == null) {
				shoppingCart = new List<ShoppingCartItem>();
			} else {
				shoppingCart = (List<ShoppingCartItem>)Session["shoppingCart"];
			}

			foreach (ShoppingCartItem ci in shoppingCart.ToList()) {
				if (ci.id == id) {
					shoppingCart.Remove(ci);
				}
			}

			// Save shopping cart
			Session["shoppingCart"] = shoppingCart;

			return PartialView("_PartialShoppingCart", shoppingCart);
		}

	}
}
