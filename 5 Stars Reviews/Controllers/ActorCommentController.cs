using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _5_Stars_Reviews.Models;

namespace _5_Stars_Reviews.Controllers
{
    public class ActorCommentController : Controller
    {
        private DBContext db = new DBContext();

        // GET: ActorComment
        public ActionResult Index()
        {
            var actorComments = db.ActorComments.Include(a => a.Actor);
            return View(actorComments.ToList());
        }

        // GET: ActorComment/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActorComment actorComment = db.ActorComments.Find(id);
            if (actorComment == null)
            {
                return HttpNotFound();
            }
            return View(actorComment);
        }

        // GET: ActorComment/Create
        public ActionResult Create()
        {
            ViewBag.ActorId = new SelectList(db.Actors, "ActorId", "ActorName");
            return View();
        }

        // POST: ActorComment/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ACommentId,AComment,ActorId")] ActorComment actorComment)
        {
            if (ModelState.IsValid)
            {
                db.ActorComments.Add(actorComment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ActorId = new SelectList(db.Actors, "ActorId", "ActorName", actorComment.ActorId);
            return View(actorComment);
        }

        // GET: ActorComment/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActorComment actorComment = db.ActorComments.Find(id);
            if (actorComment == null)
            {
                return HttpNotFound();
            }
            ViewBag.ActorId = new SelectList(db.Actors, "ActorId", "ActorName", actorComment.ActorId);
            return View(actorComment);
        }

        // POST: ActorComment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ACommentId,AComment,ActorId")] ActorComment actorComment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(actorComment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ActorId = new SelectList(db.Actors, "ActorId", "ActorName", actorComment.ActorId);
            return View(actorComment);
        }

        // GET: ActorComment/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActorComment actorComment = db.ActorComments.Find(id);
            if (actorComment == null)
            {
                return HttpNotFound();
            }
            return View(actorComment);
        }

        // POST: ActorComment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ActorComment actorComment = db.ActorComments.Find(id);
            db.ActorComments.Remove(actorComment);
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
