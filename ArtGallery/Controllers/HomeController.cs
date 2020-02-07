using ArtGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArtGallery.Controllers
{
    public class HomeController : Controller
    {
        UserRepository _userRepository;

        public HomeController()
        {
            _userRepository = new UserRepository();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AboutMe()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AboutMe(User user)
        {
            _userRepository.AddUser(user);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}