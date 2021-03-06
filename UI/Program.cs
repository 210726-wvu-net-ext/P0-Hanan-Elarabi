using System;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.IO;
using DL.Entities;
using BL;
using System.IO;
using Models;



namespace UI
{
    class Program
    {

       
        static void Main(string[] args)
        {
 
     /// <summary>
     ///  *** db connection code start***
    /// connect to database through my link in the (json) file
     /// </summary>
     /// <returns> </returns>       
 var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsetting.json")
    .Build();

//get the connection string 
    string ConnectionString = configuration.GetConnectionString("hananmydb");
    DbContextOptions<hananmydbContext> options = new DbContextOptionsBuilder<hananmydbContext>()
    .UseSqlServer(ConnectionString)
    .Options;

    var context = new hananmydbContext(options);//our instance of database
    
           ///***End of the db connection code***

            
            
    IMenu menu = new MainMenu(
    new UsersBL(new UsersRepo(context)),
    new RestaurantsBL(new RestaurantsRepo(context)),
    new ReviewsBL(new ReviewsRepo(context)))


            menu.start();
            
        }
    }
}
