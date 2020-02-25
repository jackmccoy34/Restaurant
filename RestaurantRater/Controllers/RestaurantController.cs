using RestaurantRater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace RestaurantRater.Controllers
{
    public class RestaurantController : ApiController
    {

        private readonly RestaurantDbContext _context = new RestaurantDbContext(); //_context is an exact replica of our database but will not affect the original database


        //POST
        public async Task<IHttpActionResult> PostRestaurant(Restaurant restaurant)
        {
            if (ModelState.IsValid && restaurant != null)
            {
                _context.Restaurants.Add(restaurant);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return BadRequest(ModelState);  
            //OK & BAdRequest are tied through inherting ApiController at the top
        }

        //GET ALL

        //GET BY ID

        //PUT (Update)

        //DELETE BY ID
    }
}
