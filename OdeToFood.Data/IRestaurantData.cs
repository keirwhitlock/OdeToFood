using System;
using System.Collections.Generic;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {

        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Keirs Indian", Location = "London", Cuisine = CuisineType.Indian},
                new Restaurant { Id = 2, Name = "Keirs Italian", Location = "London", Cuisine = CuisineType.Italian},
                new Restaurant { Id = 3, Name = "Keirs Mexican", Location = "London", Cuisine = CuisineType.Mexican}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
