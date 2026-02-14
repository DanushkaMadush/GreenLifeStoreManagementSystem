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

        public Order()
        {
            Items = new List<OrderItem>();
            OrderDate = DateTime.Now;
            Status = "Pending";
        }

        public bool PlaceOrder()
        {
            OrderRepository repo = new OrderRepository();
            return repo.SaveOrder(this);
        }

        public bool UpdateStatus(string status)
        {
            OrderRepository repo = new OrderRepository();
            bool result = repo.UpdateOrderStatus(this.OrderId, status);
            if (result)
                this.Status = status;
            return result;
        }

        public static List<Order> GetAllOrders()
        {
            OrderRepository repo = new OrderRepository();
            return repo.GetAllOrders();
        }

        public static List<Order> GetOrdersByCustomer(int customerId)
        {
            OrderRepository repo = new OrderRepository();
            return repo.GetOrdersByCustomer(customerId);
        }

        public static List<OrderItem> GetOrderItems(int orderId)
        {
            OrderRepository repo = new OrderRepository();
            return repo.GetOrderItems(orderId);
        }
    }
}
