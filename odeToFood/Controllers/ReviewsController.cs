using odeToFood.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace odeToFood.Controllers
{
    public class ReviewsController : Controller
    {
        odeToFoodDb db = new odeToFoodDb();

        public ActionResult Index([Bind(Prefix = "id")] int restaurantId)
        {
            var restaurant = db.Restaurants.Find(restaurantId);
            if (restaurant != null)
            {
                return View(restaurant);
            }
            return HttpNotFound();
        }
        [HttpGet]
        public ActionResult Create(int restaurantId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(RestaurantReview review)
        {
            if (ModelState.IsValid)
            {
                db.Reviews.Add(review);
                db.SaveChanges();
                return RedirectToAction("Index", new { id = review.RestaurantId });
            }
            return View(review);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = db.Reviews.Find(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(RestaurantReview review)
        {
            if (ModelState.IsValid)
            {
                db.Entry(review).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", new { id = review.RestaurantId });
            }
            return View(review);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
        //static List<RestaurantReview> reviews = new List<RestaurantReview>
        //{ new RestaurantReview
        //    { Id = 1,
        //    Rating = 2,
        //    Body = "Body For One",
        //    City= "Valpo",
        //    RestaurantId = 1,
        //    ReviewerName = "Bob"
        //    },
        //    new RestaurantReview
        //    { Id = 2,
        //    Rating = 2,
        //    Body = "Body For Two",
        //     City= "Chicago",
        //    RestaurantId = 1,
        //    ReviewerName = "Fred"
        //    },
        //     new RestaurantReview
        //    { Id = 3,
        //    Rating = 3,
        //    Body = "Body For Three",
        //    City= "New York",
        //    RestaurantId = 1,
        //    ReviewerName = "Ted"
        //    },
        //};
    }
}
