using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantRater.Models
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(): base("DefaultCOnnection")
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }

    }
}