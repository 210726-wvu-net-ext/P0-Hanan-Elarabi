using System;

namespace Models
{
    public class Users
    {
        public Users(){

        }

        public Users(int id) {
            this.Id = id;
        }

        public Users(int id, string fname, string lname, string email) {
            this.Id = id;
            this.Fname = fname;
            this.Lname = lname;
            this.Email = email;
        }

        public int Id{ get; set;}
        public string Fname{ get; set;} 
        public string Lname{ get; set;} 
        public string Email{get;set;}

        //public int reviewId{get;set} foreign key.0000000


    }
}
