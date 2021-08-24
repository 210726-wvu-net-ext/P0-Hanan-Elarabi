using System;
using System.Collections.Generic;
using Models;


namespace DL
{
    public class IResturantRepo
    {
        public interface IPetRepo
    {
        List<Resturants> GetAllResturants();

        Resturants AddAResturant(Resturants Resturant);

        Reviews AddAReview(Reviews review);

        Resturants SearchAResturantByName(string name);

        List<Reviews> GetReviewByResturantId(int resturantId);

    }
    }
}
