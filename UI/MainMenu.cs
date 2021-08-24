using System;
using Models;


namespace UI
{
   public class MainMenu :IMenu
    {
       // Users user = new Users();
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
        public void ViewAllResturants(){
            Console.WriteLine("View All Resturants.\n");
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

    }
}
