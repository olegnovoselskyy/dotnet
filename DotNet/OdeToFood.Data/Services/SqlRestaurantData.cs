﻿using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OdeToFood.Data.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly OdeToFoodDbContext db;

        public SqlRestaurantData(OdeToFoodDbContext db)
        {
            this.db = db;

        }

        public void Add(Restaurant restaurant)
        {
            db.Restaurants.Add(restaurant);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var restaurant = db.Restaurants.Find(id);
            db.Restaurants.Remove(restaurant);
            db.SaveChanges();
        }

        public Restaurant Get(int id)
        {
            return db.Restaurants.FirstOrDefault(r => r.RestaurantID == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return db.Restaurants.OrderBy(r => r.RestaurantName);
        }

        public void Update(Restaurant restaurant)
        {
            //var r = Get(restaurant.RestaurantID);
            //r.RestaurantName = restaurant.RestaurantName;
            //r.CuisineType = restaurant.CuisineType;
            //db.SaveChanges();

            // Optimistic Concurrency - prevents users from overriding changes since last time they read

            var entry = db.Entry(restaurant);
            entry.State = EntityState.Modified;
            db.SaveChanges();

        }
    }
}
