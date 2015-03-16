using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyMadnessLeague.Models;

namespace MyMadnessLeague.Controllers
{
    public class MatchupsController : Controller
    {
        private MatchupsDBContext db = new MatchupsDBContext();

        // GET: Matchups
        public ActionResult Index()
        {
            return View(db.Matchups.ToList());
        }

        // GET: Matchups/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MatchUp matchUp = db.Matchups.Find(id);
            if (matchUp == null)
            {
                return HttpNotFound();
            }
            return View(matchUp);
        }

        // GET: Matchups/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Matchups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MatchUpId,Team1,Team2,UserSelection")] MatchUp matchUp)
        {
            if (ModelState.IsValid)
            {
                db.Matchups.Add(matchUp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(matchUp);
        }

        // GET: Matchups/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MatchUp matchUp = db.Matchups.Find(id);
            if (matchUp == null)
            {
                return HttpNotFound();
            }
            return View(matchUp);
        }

        // POST: Matchups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MatchUpId,Team1,Team2,UserSelection")] MatchUp matchUp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(matchUp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(matchUp);
        }

        // GET: Matchups/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MatchUp matchUp = db.Matchups.Find(id);
            if (matchUp == null)
            {
                return HttpNotFound();
            }
            return View(matchUp);
        }

        // POST: Matchups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MatchUp matchUp = db.Matchups.Find(id);
            db.Matchups.Remove(matchUp);
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
