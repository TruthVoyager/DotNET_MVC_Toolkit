using System.Collections.Generic;
using System.Linq;
using TidyData.Models;

namespace TidyData.Services
{
    public class InMemoryRestData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id = 1, Name = "BG Cafe", Type = PlaceType.game },
                new Restaurant {Id = 2, Name = "Music Cafe", Type = PlaceType.music },
                new Restaurant {Id = 3, Name = "Beans Cafe", Type = PlaceType.regular },
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
