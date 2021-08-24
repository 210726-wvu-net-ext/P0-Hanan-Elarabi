﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class User
    {
        public User()
        {
            Reviews = new HashSet<Review>();
        }

        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}
