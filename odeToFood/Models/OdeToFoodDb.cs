using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace odeToFood.Models
{
    public class odeToFoodDb : DbContext
    {
        public odeToFoodDb() : base("name=DefaultConnection")
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReview> Reviews { get; set; }
    }
}