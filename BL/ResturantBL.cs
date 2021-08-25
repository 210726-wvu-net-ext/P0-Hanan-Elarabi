using System.Collections.Generic;
using System;
using DL;
using Models;


namespace BL
{
    public class ResturantBL : IResturantBL
    {
        private IResturantRepo _repo;

        public ResturantBL(IResturantRepo repo)
        {
            _repo = repo;
        }
        
        public List<Resturants> ViewAllResturants(){
            return _repo.GetAllResturants();
        }
         public Resturant AddAResturant(Resturants resturant)
        {
            return _repo.AddAResturant(resturant);
        }

        public Reviews AddAReview(Reviews review)
        {
            return _repo.AddAReview(review);
        }

        public Resturants SearchResturantByName(string name)
        {
            return _repo.SearchResturantByName(name);
        }

        public List<Reviews> GetReviewssByResturantId(int catId)
        {
            return _repo.GetReviewssByResturantId(int resturantId);
        }
 
    }
}
