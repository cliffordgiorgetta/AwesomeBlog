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

    }
}
