using System;

namespace Models
{
    public class Resturants
    {

        public Resturants() {}
        public Resturants(string name)
        {
            this.Name = name;
        }
        public Resturants(int id, string name, string details, string address) : this(name)
        {
            this.Id = id;
            this.Name = name;
            this.Details = details;
            this.Address = address;
            
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string Address { get; set; }
    }

        /*public Resturants(){

        }
        public Resturants(int id){ 
            this.Id = id;
        }
        
    }*/
}
