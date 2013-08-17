using MvcAssignment.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAssignment.Models
{
	public class ShoppingCartItem : Product
	{
		public int quantity { get; set; }

		public ShoppingCartItem(Product product) {
			this.id = product.id;
			this.alias = product.alias;
			this.name = product.name;
			this.number_in_stock = product.number_in_stock;
			this.old_price = product.old_price;
			this.price = product.price;
			this.description = product.description;
			this.properties = product.properties;
			this.created = product.created;
			this.modified = product.modified;

			this.quantity = 1;
		}

		public ShoppingCartItem(Product product, int quantity) {
			this.id = product.id;
			this.alias = product.alias;
			this.name = product.name;
			this.number_in_stock = product.number_in_stock;
			this.old_price = product.old_price;
			this.price = product.price;
			this.description = product.description;
			this.properties = product.properties;
			this.created = product.created;
			this.modified = product.modified;

			this.quantity = quantity;
		}

		public bool isKindOf(ShoppingCartItem other) {
			return this.id == other.id;
		}

		public bool isKindOf(Product other) {
			return this.id == other.id;
		}
	}
}