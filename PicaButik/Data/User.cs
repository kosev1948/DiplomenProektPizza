﻿using Microsoft.AspNetCore.Identity;

namespace PicaButik.Data
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public ICollection<Cart> Carts { get; set; }
    }
}
