using GreenLifeStoreManagementSystem.Repositories;
using System;
using System.Collections.Generic;

namespace GreenLifeStoreManagementSystem.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public decimal TotalAmount { get; set; }
        public List<OrderItem> Items { get; set; }

        // class constructor
        public Order()
        {
            Items = new List<OrderItem>();
            OrderDate = DateTime.Now;
            Status = "Pending";
        }

        // place the order
        public bool PlaceOrder()
        {
            OrderRepository repo = new OrderRepository();
            return repo.SaveOrder(this);
        }

        // update order status
        public bool UpdateStatus(string status)
        {
            OrderRepository repo = new OrderRepository();
            bool result = repo.UpdateOrderStatus(this.OrderId, status);
            if (result)
                this.Status = status;
            return result;
        }

        // get all orders
        public static List<Order> GetAllOrders()
        {
            OrderRepository repo = new OrderRepository();
            return repo.GetAllOrders();
        }

        // get all orders by customer
        public static List<Order> GetOrdersByCustomer(int customerId)
        {
            OrderRepository repo = new OrderRepository();
            return repo.GetOrdersByCustomer(customerId);
        }

        // get items of an order
        public static List<OrderItem> GetOrderItems(int orderId)
        {
            OrderRepository repo = new OrderRepository();
            return repo.GetOrderItems(orderId);
        }
    }
}
