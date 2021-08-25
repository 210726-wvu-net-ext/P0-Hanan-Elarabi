using Models;
using DL.Entities;
using System.Collections.Generic;
using System.Linq;
using System;

namespace DL
{
    public class ResturantRepo : IResturantRepo
    {
        private hananmydbContext _context;
        
        public ResturantRepo(hananmydbContext context)
        {
            _context = context;
        }

        public List<Models.Resturants> GetAllResturants()
        {
            return _context.Resturant.Select(
                cat => new Models.Resturants(resturant.id, resturant.dame, resturant.details, resturant.address)
            ).ToList();
        }

        public Models.Cat AddAResturant(Models.Resturants resturant)
        {
            _context.Resturants.Add(
                new Entities.Resturant{
                    Name = resturant.Name,
                    Details = resturant.Details,
                    Address = resturant.Address
                }
            );
            _context.SaveChanges();

            return resturant;
        }

        public Models.Reviews AddAReview(Models.Reviews review)
        {
            _context.Reviews.Add(
                new Entities.Review {
                   Ratings = review.Ratings,
                   Review1 = review.Review1,
                   ResturantId = review.ResturantId,
                   UsersId = review.UsersId
                }
            );
            _context.SaveChanges();

            return review;
        }

        public Models.Resturants SearchAResturantByName(string name)
        {
            Entities.Resturant foundResturant =  _context.Resturants
                .FirstOrDefault(resturant => resturant.Name == name);
            if(foundResturant != null)
            {
                return new Models.Resturants(foundResturant.Id, foundResturant.Name,foundResturant.Details, foundResturant.Address );
            }
            return new Models.Resturants();
        }

        public List<Models.Reviews> GetReviewByResturantId(int resturantId)
        {
            //Console.WriteLine("I'm in DL, getting meals by Id, {0}", catId);
            return _context.Review
                .Where(review => review.ResturantId == resturantId)
                .Select(review => new Models.Reviews{
                    Ratings = review.Ratings,
                    Review1 = review.Review1,
                    ResturantId = (int)review.ResturantId,
                    UsersId = (int)review.UsersId
                })
                .ToList();
        }

        public void DeleteAResturant(Models.Resturants resturant)
        {
            Entities.Resturant resturantToDelete = new Entities.Resturant
            {
                Id = resturant.Id,
                Name = resturant.Name,
                Details = resturant.Details,
                Address = resturant.AAddress
            };
            _context.Resturant.Remove(resturantToDelete);
            _context.SaveChanges();
        }
    }
}






























/*using System.Collections.Generic;
using Models;
using DL.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;




namespace DL
{
    public class ResturantRepo : IResturantRepo
    {
      private hananmydbContext _context;

     /* public ResturantRepo(hananmydbContext context){
          _context = context;
      }*//*
      public ResturantRepo(hananmydbContext context)
        {
            _context = context;
        }

      
        public List<Models.Resturants> GetAllResturants(){
            return _context.Resturant.Select(resturant => new Models.Resturants(resturant.Id, resturant.Name, resturant.Details, resturant.Address)
            ).ToList();
        }



        }

    }
*/
