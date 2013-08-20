using MvcAssignment.Linq;
using MvcAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAssignment.Controllers
{
    public class CheckoutController : Controller
    {
        //
        // GET: /CheckOut/

		[HttpGet]
        public ActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public ActionResult Index(Contact contact) {


			return View();
		}

		/**
		 * Show checkout cart.
		 * @return		Partial HTML view of the checkout cart.
		 */
		public ActionResult ShowCart() {
			// Load shopping cart from session
			List<ShoppingCartItem> shoppingCart;
			if (Session["shoppingCart"] == null) {
				shoppingCart = new List<ShoppingCartItem>();
			} else {
				shoppingCart = (List<ShoppingCartItem>)Session["shoppingCart"];
			}

			return PartialView("_PartialCheckoutCart", shoppingCart);
		}

		/**
		 * Remove item from checkout cart.
		 * @param int	Product id.
		 * @return		Partial HTML view of the checkout cart.
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

			return PartialView("_PartialCheckoutCart", shoppingCart);
		}

		/**
		 * Edit quantity of a product to checkout cart.
		 * @param int	Product id.
		 * @param int	Product quantity.
		 * @return		Partial HTML view of the checkout cart.
		 */
		public ActionResult EditCart(int id, int quantity) {

			// Load shopping cart from session
			List<ShoppingCartItem> shoppingCart;
			if (Session["shoppingCart"] == null) {
				shoppingCart = new List<ShoppingCartItem>();
			} else {
				shoppingCart = (List<ShoppingCartItem>)Session["shoppingCart"];
			}

			foreach (ShoppingCartItem ci in shoppingCart.ToList()) {
				if (ci.id == id) {
					ci.quantity = quantity;
				}
			}

			// Save shopping cart
			Session["shoppingCart"] = shoppingCart;

			return PartialView("_PartialCheckoutCart", shoppingCart);
		}

    }
}
