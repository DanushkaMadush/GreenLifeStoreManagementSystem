using System.Collections.Generic;
using System.Linq;

namespace GreenLifeStoreManagementSystem.Models
{
    public class CartModel
    {
        public List<CartItem> Items { get; set; }

        //create cart
        public CartModel()
        {
            Items = new List<CartItem>();
        }

        //add items to the cart
        public void AddItem(Product product, int quantity)
        {
            CartItem existingItem =
                Items.FirstOrDefault(i => i.Product.ProductId == product.ProductId);

            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                CartItem item = new CartItem()
                {
                    Product = product,
                    Quantity = quantity
                };

                Items.Add(item);
            }
        }

        //remove items from the cart
        public void RemoveItem(int productId)
        {
            CartItem item =
                Items.FirstOrDefault(i => i.Product.ProductId == productId);

            if (item != null)
            {
                Items.Remove(item);
            }
        }

        //update item qtys in the cart
        public void UpdateQuantity(int productId, int quantity)
        {
            CartItem item =
                Items.FirstOrDefault(i => i.Product.ProductId == productId);

            if (item != null)
            {
                item.Quantity = quantity;
            }
        }

        //get the total of cart items
        public decimal GetTotal()
        {
            return Items.Sum(i => i.SubTotal);
        }

        //clear the cart
        public void Clear()
        {
            Items.Clear();
        }
    }

    public static class CartManager
    {
        private static CartModel _cartInstance;

        public static CartModel GetCart()
        {
            if (_cartInstance == null)
            {
                _cartInstance = new CartModel();
            }
            return _cartInstance;
        }
    }
}
