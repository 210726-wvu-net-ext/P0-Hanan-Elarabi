using System.Collections.Generic;
using Models;


namespace DL
{
    public interface IResturantRepo
    {
        List<Resturant> GetAllResturants();

        Resturant AddAResturant(Resturant resturant);

        Review AddAMeal(Review review);

        Resturant SearchAResturantByName(string name);

        List<Review> GetReviewByResturantId(int resturantId);

        void DeleteAResturant(Resturant resturant);
    }
}













