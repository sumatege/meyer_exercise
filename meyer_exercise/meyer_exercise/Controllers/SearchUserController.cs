using meyer_exercise.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
        
    }
}