using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { RestaurantID = 1, RestaurantName = "Wendy's", CuisineType = CuisineType.American },
                new Restaurant { RestaurantID = 2, RestaurantName = "Oleg's Pizza", CuisineType = CuisineType.Italian },
                new Restaurant { RestaurantID = 3, RestaurantName = "Hong Kong Buffet", CuisineType = CuisineType.Chinese },
                new Restaurant { RestaurantID = 4, RestaurantName = "Taj Mahal Courtyard", CuisineType = CuisineType.Indian },
                new Restaurant { RestaurantID = 5, RestaurantName = "Eiffel Tower Eatery", CuisineType = CuisineType.French }
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
