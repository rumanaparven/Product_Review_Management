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
        public void SelectedRecords(List<ProductReviwe> listProductReview)
        {
            var recordedData = from productReviews in listProductReview
                               where (productReviews.ProductID == 1 && productReviews.Rating > 3) ||
                                 (productReviews.ProductID == 4 && productReviews.Rating > 3) ||
                                 (productReviews.ProductID == 9 && productReviews.Rating > 3)
                               select productReviews;
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID: " + list.ProductID + " UserID: " + list.UserID + " Rating: " + list.Rating + " Review: " + list.Review
                    + " isLike: " + list.isLike);
            }
        }
        public void RetrieveCountOfRecords(List<ProductReviwe> listProductReview)
        {
            var recordedData = listProductReview.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach(var list in recordedData)
            {
                Console.WriteLine(list.ProductID + "-----" + list.Count);
            }
        }
        public void RetrieveReviewGroupByProductID(List<ProductReviwe> listProductReview)
        {
            var result = listProductReview.Select(x => new { productId = x.ProductID, review = x.Review });

            foreach (var element in result)
            {
                Console.WriteLine(element.productId + " " + element.review);
            }
        }
        public void SkipTopFiveRecords(List<ProductReviwe> listProductReview)
        {
            var result = (from productReviews in listProductReview
                          select productReviews).Skip(5);

            foreach (var list in result)
            {
                Console.WriteLine("ProductID: " + list.ProductID + " UserID: " + list.UserID + " Rating: " + list.Rating + " Review: " + list.Review
                    + " isLike: " + list.isLike);
            }
        }
    }
}
