using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AwesomeBlog.Controllers
{
    public class HomeController : Controller
    {

        //step 1. set up database access
        Models.myBlogEntities db = new Models.myBlogEntities();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var list = db.Posts.OrderByDescending(x => x.PostID);
            return View(list);

         
        }

        public ActionResult Like(int id)
        {
            var post = db.Posts.Where(x => x.PostID == id).First();
            post.likes += 1;
            db.SaveChanges();

            return RedirectToAction("Index");

        }
        public ActionResult addComment(int id, FormCollection values)
        {
            // making a new comment
            var comment = new Models.Comment();
            comment.PostID = id;
            comment.author = values["Author"];
            comment.body = values["Body"];
            comment.date = DateTime.Now;
            comment.likes = 0;
            db.Comments.Add(comment);
            db.SaveChanges();

            return RedirectToAction("Index");

        }
        public ActionResult advertisement()
        {
            return View();
        }
        public ActionResult videogames()
        {
            return View();
        }
        public ActionResult email()
        {
            return View();
        }



    }
}
