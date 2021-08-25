using Models;
using BL;
using DL;
using System;
using System.Collections.Generic;
using Serilog;

/// <summary>
/// This is the Main Menu app that has the method to display usres, 
/// Resturants  and reviews for the resturants
/// </summary>

namespace UI
{
   public class MainMenu :IMenu
    {

        public MainMenu(IResturantBL bl)
        {
            _resturantbl = bl;
            Log.Logger = new LoggerConfiguration()
                            .MinimumLevel.Debug()
                            .WriteTo.Console()
                            .WriteTo.File("../logs/resturantlogs.txt", rollingInterval:RollingInterval.Day)
                            .CreateLogger();
            Log.Information("UI begining");
        }


      public void start(){
          bool repeat = true;
        do{
          Console.WriteLine("Welcome to Hanan's resturants app!");
          Console.WriteLine("[0] Exit.");
          Console.WriteLine("[1] View All Resturants");
          Console.WriteLine("[2] Add a review for a resturant");//insert user info then review
          Console.WriteLine("[3] Show other customers reviews.");

            switch(Console.ReadLine()){
                case "0":
                   Console.WriteLine("Good Buy!\n");
                    repeat = false;
                    break;
                case "1":
                        ViewAllResturants();
                    break;
                case "2":
                        AddAReview();
                    break;
                case "3":
                        ShowReviews();
                        break;
                case "4":
                       ShowUsers();
                    break;
                    default:
                        Console.WriteLine("We don't understand what you are doing!\n");
                    break;

            }
            }while(repeat);

       }
        
        public void AddAReview(){
            Console.WriteLine("Add a review for a resturant.\n");
        }
        public void ShowReviews(){
            Console.WriteLine("Show other customers reviews.\n");
        }

        public void ShowUsers(){

            Console.WriteLine("Show users\n");
        }

       /// <summary>
       /// method to display all resturants from resturants table
       /// </summary>

        private void ViewAllResturants() 
        {
            List<Resturant> resturant = _resturantbl.ViewAllResturants();
            foreach(Resturant resturant in resturants)
            {
                Console.WriteLine($"{resturant.Id}");
                Console.WriteLine($"{resturant.Name}");
                Console.WriteLine($"{resturant.Details}");
                Console.WriteLine($"{resturant.Address}");

                Console.WriteLine("-----------------------------------------");
            }
        }

    }
}
