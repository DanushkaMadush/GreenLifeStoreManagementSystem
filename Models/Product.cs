using GreenLifeStoreManagementSystem.Repositories;
using System.Collections.Generic;

namespace GreenLifeStoreManagementSystem.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Supplier { get; set; }
        public decimal Discount { get; set; }

        public Product()
        {
        }

        public Product(string name, string category, decimal price,
                       int stock, string supplier, decimal discount)
        {
            ProductName = name;
            Category = category;
            Price = price;
            Stock = stock;
            Supplier = supplier;
            Discount = discount;
        }

        public bool Add()
        {
            ProductRepository repo = new ProductRepository();
            return repo.AddProduct(this);
        }

        public bool Update()
        {
            ProductRepository repo = new ProductRepository();
            return repo.UpdateProduct(this);
        }

        public bool Delete()
        {
            ProductRepository repo = new ProductRepository();
            return repo.DeleteProduct(ProductId);
        }

        public static List<Product> GetAllProducts()
        {
            ProductRepository repo = new ProductRepository();
            return repo.GetAllProducts();
        }

        public static List<Product> SearchProducts(string keyword)
        {
            ProductRepository repo = new ProductRepository();
            return repo.SearchProducts(keyword);
        }

        public static Product GetProductById(int productId)
        {
            ProductRepository repo = new ProductRepository();
            return repo.GetProductById(productId);
        }

        public static List<Product> GetProductsByCategory(string category)
        {
            ProductRepository repo = new ProductRepository();
            return repo.GetProductsByCategory(category);
        }

        public static List<Product> GetProductsByPriceRange(decimal minPrice, decimal maxPrice)
        {
            ProductRepository repo = new ProductRepository();
            return repo.GetProductsByPriceRange(minPrice, maxPrice);
        }

        public static List<Product> GetAvailableProducts()
        {
            ProductRepository repo = new ProductRepository();
            return repo.GetAvailableProducts();
        }
    }
}
