using System;


namespace Models
{
    public class Reviews
    {
        public Reviews() { }
        public Reviews(int id, int ratings)
        {
            this.Id = id;
            this.Ratings = ratings;
            this.Review1 = Review1;

            if (string.IsNullOrEmpty(ratings.ToString()))
            {
                throw new ArgumentException("invalid value for food type");
            }
            this.Ratings = ratings;
        }

        public int Id { get; set; }
        public int Ratings { get; set; }
        public string Review1 { get; set; }
        public int ResturantId { get; set; }
        public int UsersId { get; set; }
    }

}











        /*public Reviews(int rating, string review, int restaurantId){
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
        public int Rating { get; set; }*/



    

