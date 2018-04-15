using CampusBets.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;


namespace CampusBets.Controllers
{
    public class EventListController : Controller
    {
        private CampusBetsEntities1 db = new CampusBetsEntities1();

        // GET: Events
        public ActionResult Index()
        {

            return View(db.Events.ToList());
        }

        // GET: Events/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Events @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // GET: Events/Create
        public ActionResult Create()
        {
            ViewBag.Id_Team1 = new SelectList(db.Teams, "Id_Team", "Name");
            ViewBag.Id_Team2 = new SelectList(db.Teams, "Id_Team", "Name");
            ViewBag.Id_Tip = new SelectList(db.Tip_Event, "Id_Tip", "Denumire");
            return View();
        }

        // POST: Events/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_Ev,Id_Team1,Id_Team2,Date_And_Time,Id_Tip,Odd_1,Odd_x,Odd_2,Odd_GG,Odd_peste25,Odd_sub25,Odd_SC,Odd_1x,Odd_12,Odd_x2")] Events @event)
        {
            if (ModelState.IsValid)
            {
                @event.Id_Ev = Guid.NewGuid();
                db.Events.Add(@event);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id_Team1 = new SelectList(db.Teams, "Id_Team", "Name", @event.Id_Team1);
            ViewBag.Id_Team2 = new SelectList(db.Teams, "Id_Team", "Name", @event.Id_Team2);
            ViewBag.Id_Tip = new SelectList(db.Tip_Event, "Id_Tip", "Denumire", @event.Id_Tip);
            return View(@event);
        }

        // GET: Events/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Events @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id_Team1 = new SelectList(db.Teams, "Id_Team", "Name", @event.Id_Team1);
            ViewBag.Id_Team2 = new SelectList(db.Teams, "Id_Team", "Name", @event.Id_Team2);
            ViewBag.Id_Tip = new SelectList(db.Tip_Event, "Id_Tip", "Denumire", @event.Id_Tip);
            return View(@event);
        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_Ev,Id_Team1,Id_Team2,Date_And_Time,Id_Tip,Odd_1,Odd_x,Odd_2,Odd_GG,Odd_peste25,Odd_sub25,Odd_SC,Odd_1x,Odd_12,Odd_x2")] Events @event)
        {
            if (ModelState.IsValid)
            {
                db.Entry(@event).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id_Team1 = new SelectList(db.Teams, "Id_Team", "Name", @event.Id_Team1);
            ViewBag.Id_Team2 = new SelectList(db.Teams, "Id_Team", "Name", @event.Id_Team2);
            ViewBag.Id_Tip = new SelectList(db.Tip_Event, "Id_Tip", "Denumire", @event.Id_Tip);
            return View(@event);
        }

        // GET: Events/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Events @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // POST: Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Events @event = db.Events.Find(id);
            db.Events.Remove(@event);
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
