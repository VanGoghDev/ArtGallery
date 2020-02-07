using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArtGallery.Models
{
    public class UserRepository
    {
        public void AddUser(User user)
        {
            using (UserContext db = new UserContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }
    }
}