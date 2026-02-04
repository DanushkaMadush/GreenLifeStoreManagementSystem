namespace GreenLifeStoreManagementSystem.Models
{
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public decimal SubTotal
        {
            get
            {
                decimal priceAfterDiscount =
                    Product.Price - (Product.Price * Product.Discount / 100);
                return priceAfterDiscount * Quantity;
            }
        }
    }
}
