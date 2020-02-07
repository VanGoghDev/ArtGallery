using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArtGallery.Models
{
    public class User
    {
        public int UserId { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
    }
}