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
    public class FilmController : Controller
    {
        private DBContext db = new DBContext();

        // GET: Film
        public ActionResult Index()
        {
            var films = db.Films.Include(f => f.Director);
            return View(films.ToList());
        }

        // GET: Film/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // GET: Film/Create
        public ActionResult Create()
        {
            ViewBag.Actors = new SelectList(db.Actors, "ActorId", "ActorName");
            ViewBag.DirectorId = new SelectList(db.Directors, "DirectorId", "DirectorName");
            return View();
        }

        // POST: Film/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "FilmId,FilmName,Description,ReleaseDate,Genre,DirectorId,ActorId")] Film film)
        {
            if (ModelState.IsValid)
            {
                db.Films.Add(film);

                var actorIds = Request.Unvalidated.Form["Actors"];
                addActorsToFilm(film, actorIds);

                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Actors = new SelectList(db.Actors, "ActorId", "ActorName");
            ViewBag.DirectorId = new SelectList(db.Directors, "DirectorId", "DirectorName", film.DirectorId);
            return View(film);
        }

        // GET: Film/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Film film = db.Films.Find(id);

            var actorIds = film.Actors.Select(c => c.ActorId).ToArray();

            if (film == null)

            {
                return HttpNotFound();
            }

            ViewBag.Actors = new SelectList(db.Actors, "ActorId", "ActorName", actorIds);
            ViewBag.DirectorId = new SelectList(db.Directors, "DirectorId", "DirectorName", film.DirectorId);
            return View(film);
        }

        // POST: Film/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "FilmId,FilmName,Description,ReleaseDate,Genre,DirectorId,ActorId")] Film film)
        {
            if (ModelState.IsValid)
            {
                db.Entry(film).State = EntityState.Modified;

                DeleteActorsFromFilm(film);

                var actorIds = Request.Unvalidated.Form["Actors"];
                addActorsToFilm(film, actorIds);

                db.SaveChanges();
                return RedirectToAction("Index");
            }
           
            return View(film);
        }

        // GET: Film/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // POST: Film/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Film film = db.Films.Find(id);
            db.Films.Remove(film);
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

        private void addActorsToFilm(Film film, String actorsIds)
        {
            foreach(var ActorId in actorsIds.Split(','))
            {
                var intActorId = int.Parse(ActorId);
                Actor actor = db.Actors.Where(ctor => ctor.ActorId == intActorId).First();
                actor.Films.Add(film);
                if(film.Actors != null)
                {
                    film.Actors.Add(actor);
                }
            }
        }

        private void DeleteActorsFromFilm(Film film)
        {
            db.Entry(film).Collection(p => p.Actors).Load();
            var listActors = film.Actors.ToList();
            foreach (var actor in listActors)
            {
                film.Actors.Remove(actor);
            }
        }



    }
}
