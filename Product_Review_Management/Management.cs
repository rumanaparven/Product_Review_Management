using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Product_Review_Management
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();
        public void TopRecords(List<ProductReviwe> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);

            foreach(var list in recordedData)
            {
                Console.WriteLine("ProductID: "+list.ProductID + " UserID: " + list.UserID + " Rating: " + list.Rating + " Review: " + list.Review
                    + " isLike: " + list.isLike);
            }
        }
    }
}
