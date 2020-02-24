using ArtGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArtGallery.DomainModels;
using Newtonsoft.Json;

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
            Order order = new Order();
            order.User = user;
            _userRepository.AddUser(user, order);
            return View();
        }

        public ActionResult About()
        {

            
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public string Cluster()
        {
            Routes routes = new Routes();
            routes.UploadPoints("C:/VS Projects/ArtGallery/ArtGallery/ArtGallery/App_Data/Paths.txt");
            kMeanCluster kmeanCluster = new kMeanCluster();
            kmeanCluster.setPoint(routes.allPoints);
            kmeanCluster.clustering();
            List<Cluster> pointsList = kmeanCluster.clusterList;
            List<Point>[] points = { kmeanCluster.clusterList[0].points, kmeanCluster.clusterList[1].points }; 
            string json = JsonConvert.SerializeObject(points);
            return json;
        }

        public ActionResult Contact()
        {
            

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}