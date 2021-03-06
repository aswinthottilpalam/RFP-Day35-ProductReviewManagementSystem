using System;
using System.Collections.Generic;

namespace ProductReviewManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management System");
            Console.WriteLine("Adding a Prodcut Review In list");
            Console.WriteLine("Enter Option");
            int option = Convert.ToInt32(Console.ReadLine());

            List<ProductReview> productReviews = new List<ProductReview>();

            switch (option)
            {
                case 1:
                    Management.AddingProductReview(productReviews);
                    break;
                case 2:
                    Management.RetrieveTopThreeRating(productReviews);
                    break;
                case 3:
                    Management.RetrieveRecordsBasedOnRatingAndProductId(productReviews);
                    break;
                case 4:
                    Management.CountingProductId(productReviews);
                    break;
                case 5:
                    Management.RetrieveOnlyProductIdAndReviews(productReviews);
                    break;
                case 6:
                    Management.SkipTop5RecordsFromListAndRetrieveOtherData(productReviews);
                    break;
                case 7:
                    Management.RetrieveProductIDAndReview1(productReviews);
                    break;
            }
        }
    }
}
