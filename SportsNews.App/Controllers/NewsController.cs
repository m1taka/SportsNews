using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using SportsNews.Data;
using System.Net;

namespace SportsNews.App.Controllers
{
    public class NewsController : BaseController
    {
        SportsNewsData db = new SportsNewsData();

        // GET: News
        [HttpGet]
        public ActionResult Index()
        {
            var news = db.NewsArticles.ToList();

            return View(news);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewsArticles newsArticles = db.NewsArticles.Find(id);
            if (newsArticles == null)
            {
                return HttpNotFound();
            }
            return View(newsArticles);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Headline,PublishDate,Text,ClientQuote,Tags,PhotoURL")] NewsArticles newsArticles)
        {
            if (ModelState.IsValid)
            {
                db.NewsArticles.Add(newsArticles);
                db.SaveChanges();
                return RedirectToAction("Index");                 
            }
            return View(newsArticles);
        }

        
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewsArticles newsArticles = db.NewsArticles.Find(id);
            if (newsArticles == null)
            {
                return HttpNotFound();
            }
            return View(newsArticles);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Headline,PublishDate,Text,PhotoURL")] NewsArticles newsArticles)
        {
            if (ModelState.IsValid)
            { 
                db.Entry(newsArticles).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newsArticles);
        }
        

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            NewsArticles newsArticles = db.NewsArticles.Find(id);
            if (newsArticles == null)
            {
                return HttpNotFound();
            }
            return View(newsArticles); 
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteComfirmed(int id)
        {
            NewsArticles newsArticles = db.NewsArticles.Find(id);
            db.NewsArticles.Remove(newsArticles);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}