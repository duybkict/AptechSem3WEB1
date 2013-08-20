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
		public ActionResult Index() {
			return View();
		}

		[HttpPost]
		public ActionResult Index(String email, String fullname, String telephone, String address,
String receiver_email, String receiver_fullname, String receiver_telephone, String receiver_address) {
			ElectonicShopDataContext db = new ElectonicShopDataContext();

			try {
				Contact contact = new Contact {
					email = email,
					fullname = fullname,
					telephone = telephone,
					address = address,
					created = DateTime.Now
				};
				db.Contacts.InsertOnSubmit(contact);
				db.SubmitChanges();

				int lastInsertedContactId = (from c in db.Contacts
										 orderby c.id descending
										 select c.id).ToList().FirstOrDefault();

				Order order;
				if (receiver_address != null) {
					order = new Order {
						order_contact_id = lastInsertedContactId,
						receiver_address = receiver_address,
						receiver_email = receiver_email,
						receiver_fullname = receiver_fullname,
						receiver_telephone = receiver_telephone,
						created = DateTime.Now,
						status = 1
					};
				} else {
					order = new Order {
						order_contact_id = lastInsertedContactId,
						receiver_address = address,
						receiver_email = email,
						receiver_fullname = fullname,
						receiver_telephone = telephone,
						created = DateTime.Now,
						status = 1
					};
				}
				

				db.Orders.InsertOnSubmit(order);

				db.SubmitChanges();

				int lastInsertedOrderId = (from o in db.Orders
											 orderby o.id descending
											 select o.id).First();

				List<ShoppingCartItem> shoppingCart = (List<ShoppingCartItem>)Session["shoppingCart"];
				foreach (ShoppingCartItem ci in shoppingCart) {
					OrderDetail orderDetail = new OrderDetail {
						product_id = ci.id,
						order_id = lastInsertedOrderId,
						number = ci.quantity
					};

					db.OrderDetails.InsertOnSubmit(orderDetail);

					db.SubmitChanges();
				}
				
				ViewData["status"] = "success";
			} catch (Exception e) { 
				ViewData["status"] = "error";
			}

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
