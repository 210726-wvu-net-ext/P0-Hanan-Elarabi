using System;

namespace Models
{
    public class Reviews
    {
        public Reviews(int rating, string review, int restaurantId){
            this.Rating = rating;
            this.Review = review;
            this.RestaurantId = restaurantId;
        }
        public Reviews(int rating, string review, int restaurantId, int userId){
            this.Rating = rating;
            this.Review = review;
            this.RestaurantId = restaurantId;
            this.UserId = userId;
        }
        public int Id { get; set; }
        public string Review { get; set; }
        public int UserId { get; set; }
        public int RestaurantId { get; set; }
        public int Rating { get; set; }

        //public DateTime Date { get; set; }


    }
}
