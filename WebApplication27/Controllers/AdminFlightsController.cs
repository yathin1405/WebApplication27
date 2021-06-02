using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication27.Data;
using WebApplication27.Models;

namespace WebApplication27.Controllers
{
    public class AdminFlightsController : Controller
    {
        private WebApplication27Context db = new WebApplication27Context();

        // GET: AdminFlights
        public ActionResult Index()
        {
            return View(db.AdminFlights.ToList());
        }
        public ActionResult LandingPage()
        {
            return View(db.AdminFlights.ToList());
        }

        // GET: AdminFlights/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdminFlight adminFlight = db.AdminFlights.Find(id);
            if (adminFlight == null)
            {
                return HttpNotFound();
            }
            return View(adminFlight);
        }

        // GET: AdminFlights/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminFlights/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PlaneID,LocationFrom,LocationTO,AeroplaneName,DepartureTime,SeatingCapacity,Price")] AdminFlight adminFlight)
        {
            if (ModelState.IsValid)
            {
                db.AdminFlights.Add(adminFlight);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adminFlight);
        }

        // GET: AdminFlights/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdminFlight adminFlight = db.AdminFlights.Find(id);
            if (adminFlight == null)
            {
                return HttpNotFound();
            }
            return View(adminFlight);
        }

        // POST: AdminFlights/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PlaneID,LocationFrom,LocationTO,AeroplaneName,DepartureTime,SeatingCapacity,Price")] AdminFlight adminFlight)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adminFlight).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adminFlight);
        }

        // GET: AdminFlights/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdminFlight adminFlight = db.AdminFlights.Find(id);
            if (adminFlight == null)
            {
                return HttpNotFound();
            }
            return View(adminFlight);
        }

        // POST: AdminFlights/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AdminFlight adminFlight = db.AdminFlights.Find(id);
            db.AdminFlights.Remove(adminFlight);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
