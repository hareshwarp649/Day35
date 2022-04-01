using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManage5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prodcut Review Management!!!!!!!!");
            Console.WriteLine("Adding a Prodcut Review In list");
            Console.WriteLine("Enter Option");
            int option = Convert.ToInt32(Console.ReadLine());
            //Creating a list for Product Review
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

            }
        }
    }
}
