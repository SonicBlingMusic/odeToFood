using odeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace odeToFood.Controllers
{
    public class ReviewsController : Controller
    {
        // GET: Reviews
        public ActionResult Index()
        {
            return View(reviews);
        }

        // GET: Reviews/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reviews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reviews/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reviews/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reviews/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reviews/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reviews/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        static List<RestaurantReview> reviews = new List<RestaurantReview>
        { new RestaurantReview
            { Id = 1,
            Rating = 2,
            Body = "Body For One",
            City= "Valpo",
            RestaurantId = 1,
            ReviewerName = "Bob"
            },
            new RestaurantReview
            { Id = 2,
            Rating = 2,
            Body = "Body For Two",
             City= "Chicago",
            RestaurantId = 1,
            ReviewerName = "Fred"
            },
             new RestaurantReview
            { Id = 3,
            Rating = 3,
            Body = "Body For Three",
            City= "New York",
            RestaurantId = 1,
            ReviewerName = "Ted"
            },
        };
    }
}
