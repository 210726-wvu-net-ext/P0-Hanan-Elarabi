using System;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.IO;
using DL.Entities;

namespace UI
{
    class Program
    {

       
        static void Main(string[] args)
        {
             //*** db connection code start***//

 //connect to database through my link in the (json) file
 var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsetting.json")
    .Build();

//get the connection string 
    string ConnectionString = configuration.GetConnectionString("hananmydb");
//(I must review fils names)
    DbContextOptions<hananmydbContext> options = new DbContextOptionsBuilder<hananmydbContext>()
    .UseSqlServer(ConnectionString)
    .Options;

    var context = new hananmydbContext(options);//our instance of database
    
            //***End of the db connection code***//

            
            
            IMenu menu = new MainMenu();
            menu.start();
            
        }
    }
}
