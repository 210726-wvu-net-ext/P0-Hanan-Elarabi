using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class Review
    {
        public int Id { get; set; }
        public int Ratings { get; set; }
        public string Review1 { get; set; }
        public int ResturantId { get; set; }
        public int UsersId { get; set; }

        public virtual Resturant Resturant { get; set; }
        public virtual User Users { get; set; }
    }
}
