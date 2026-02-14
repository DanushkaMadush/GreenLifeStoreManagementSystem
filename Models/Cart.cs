using System.Collections.Generic;
using System.Linq;

namespace GreenLifeStoreManagementSystem.Models
{
    public class CartModel
    {
        public List<CartItem> Items { get; set; }

        public CartModel()
        {
            Items = new List<CartItem>();
        }

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

        public void RemoveItem(int productId)
        {
            CartItem item =
                Items.FirstOrDefault(i => i.Product.ProductId == productId);

            if (item != null)
            {
                Items.Remove(item);
            }
        }

        public void UpdateQuantity(int productId, int quantity)
        {
            CartItem item =
                Items.FirstOrDefault(i => i.Product.ProductId == productId);

            if (item != null)
            {
                item.Quantity = quantity;
            }
        }

        public decimal GetTotal()
        {
            return Items.Sum(i => i.SubTotal);
        }

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
