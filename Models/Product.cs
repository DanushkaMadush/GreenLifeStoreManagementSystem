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

        // product class constructor with no params
        public Product()
        {
        }

        // product class constructor with params - method overloading
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

        // add new product
        public bool Add()
        {
            ProductRepository repo = new ProductRepository();
            return repo.AddProduct(this);
        }

        // update product details
        public bool Update()
        {
            ProductRepository repo = new ProductRepository();
            return repo.UpdateProduct(this);
        }
        
        // delete product
        public bool Delete()
        {
            ProductRepository repo = new ProductRepository();
            return repo.DeleteProduct(ProductId);
        }

        // get all products
        public static List<Product> GetAllProducts()
        {
            ProductRepository repo = new ProductRepository();
            return repo.GetAllProducts();
        }

        // search products
        public static List<Product> SearchProducts(string keyword)
        {
            ProductRepository repo = new ProductRepository();
            return repo.SearchProducts(keyword);
        }

        // get product by id
        public static Product GetProductById(int productId)
        {
            ProductRepository repo = new ProductRepository();
            return repo.GetProductById(productId);
        }

        // get product by category
        public static List<Product> GetProductsByCategory(string category)
        {
            ProductRepository repo = new ProductRepository();
            return repo.GetProductsByCategory(category);
        }

        // get product by price category
        public static List<Product> GetProductsByPriceRange(decimal minPrice, decimal maxPrice)
        {
            ProductRepository repo = new ProductRepository();
            return repo.GetProductsByPriceRange(minPrice, maxPrice);
        }

        // get available products
        public static List<Product> GetAvailableProducts()
        {
            ProductRepository repo = new ProductRepository();
            return repo.GetAvailableProducts();
        }
    }
}
