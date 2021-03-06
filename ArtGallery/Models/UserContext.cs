﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ArtGallery.Models
{
    public class UserContext: DbContext
    {
        public UserContext()
            : base("DBConnection")
        { }

        public DbSet<User> Users { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}