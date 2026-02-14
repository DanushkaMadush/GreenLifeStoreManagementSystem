using GreenLifeStoreManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLifeStoreManagementSystem.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }

        public Review()
        {
            ReviewDate = DateTime.Now;
        }

        public bool AddReview()
        {
            ReviewRepository repo = new ReviewRepository();
            return repo.AddReview(this);
        }

        public static List<Review> GetReviewsByProduct(int productId)
        {
            ReviewRepository repo = new ReviewRepository();
            return repo.GetReviewsByProduct(productId);
        }

        public static bool HasCustomerReviewed(int productId, int customerId)
        {
            ReviewRepository repo = new ReviewRepository();
            return repo.HasCustomerReviewed(productId, customerId);
        }
    }
}
