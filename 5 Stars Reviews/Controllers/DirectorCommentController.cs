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
    public class DirectorCommentController : Controller
    {
        private DBContext db = new DBContext();

        // GET: DirectorComment
        public ActionResult Index()
        {
            var directorComments = db.DirectorComments.Include(d => d.Director);
            return View(directorComments.ToList());
        }

        // GET: DirectorComment/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DirectorComment directorComment = db.DirectorComments.Find(id);
            if (directorComment == null)
            {
                return HttpNotFound();
            }
            return View(directorComment);
        }

        // GET: DirectorComment/Create
        public ActionResult Create()
        {
            ViewBag.DirectorId = new SelectList(db.Directors, "DirectorId", "DirectorName");
            return View();
        }

        // POST: DirectorComment/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DCommentId,DComment,DirectorId")] DirectorComment directorComment)
        {
            if (ModelState.IsValid)
            {
                db.DirectorComments.Add(directorComment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DirectorId = new SelectList(db.Directors, "DirectorId", "DirectorName", directorComment.DirectorId);
            return View(directorComment);
        }

        // GET: DirectorComment/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DirectorComment directorComment = db.DirectorComments.Find(id);
            if (directorComment == null)
            {
                return HttpNotFound();
            }
            ViewBag.DirectorId = new SelectList(db.Directors, "DirectorId", "DirectorName", directorComment.DirectorId);
            return View(directorComment);
        }

        // POST: DirectorComment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DCommentId,DComment,DirectorId")] DirectorComment directorComment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(directorComment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DirectorId = new SelectList(db.Directors, "DirectorId", "DirectorName", directorComment.DirectorId);
            return View(directorComment);
        }

        // GET: DirectorComment/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DirectorComment directorComment = db.DirectorComments.Find(id);
            if (directorComment == null)
            {
                return HttpNotFound();
            }
            return View(directorComment);
        }

        // POST: DirectorComment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DirectorComment directorComment = db.DirectorComments.Find(id);
            db.DirectorComments.Remove(directorComment);
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
