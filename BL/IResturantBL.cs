using System;
using DL;
using Models;
using System.Collections.Generic;


namespace BL

{
public interface IResturantBL
    {
        List<Resturants> ViewAllResturants();
        Cat AddAResturant(Resturants resturant);
        Meal AddAReview(Review review);
        Cat SearchResturantByName(string name);
        List<Meal> GetReviewssByResturantId(int resturantId);
    }
    //public interface IResturantBL{
    //List<Resturants> ViewAllResturants();

    //}
}
