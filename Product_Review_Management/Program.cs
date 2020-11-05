using System;
using System.Collections.Generic;

namespace Product_Review_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to product review management");
     
            List<ProductReviwe> productReviewList = new List<ProductReviwe>()
            {
                new ProductReviwe(){ProductID=1,UserID=1,Rating=5,Review="Good",isLike=true },
                new ProductReviwe(){ProductID=1,UserID=1,Rating=5,Review="Good",isLike=true },
                new ProductReviwe(){ProductID=3,UserID=3,Rating=2,Review="Nice",isLike=true },
                new ProductReviwe(){ProductID=4,UserID=4,Rating=1,Review="Bad",isLike=true },
                new ProductReviwe(){ProductID=5,UserID=5,Rating=4,Review="Good",isLike=true },
            };
            foreach (var list in productReviewList)
            {
                Console.WriteLine("ProductID: " + list.ProductID + " UserID: " + list.UserID + " Rating: " + list.Rating + " Review: " + list.Review
                    + " isLike: " + list.isLike);
            }
            Console.WriteLine("Top Records : ");
            Management management = new Management();
            management.TopRecords(productReviewList);

        }
    }
}
