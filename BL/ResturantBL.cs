using System;
using DL;

namespace BL
{
    public class ResturantBL : IResturantBL
    {
        private IResturantRepo _repo;
        public ResturantBL(IResturantRepo repo){
            _repo = repo;
        } 
        
        }

    }

