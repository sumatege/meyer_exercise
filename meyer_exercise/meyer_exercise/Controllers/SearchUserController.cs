using meyer_exercise.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace meyer_exercise.Controllers
{

    public class SearchUserController : Controller
    {
        // GET: SearchUser
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
     
        public ActionResult Repository(string id)
        {
            ViewBag.User_title = id;
            return View();
        }
    }
}