using BallisticsCalcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BallisticsCalcApp.Controllers
{
    public class BallisticsController : Controller
    {   
        public ActionResult Index()
        {
            Ballistics ballistics = new Ballistics();

            return View("Index", ballistics);
        }

        [HttpPost]
        public ActionResult Index(Ballistics ballistics)
        {
            return View("Index", ballistics);
        }

        [HttpPost]
        [ChildActionOnly]
        public ActionResult _EnterData(Ballistics ballistics)
        {
           
            return PartialView("_EnterData", ballistics);
        }

        // GET: Ballistics/Create
        [HttpPost]
        public ActionResult Result(Ballistics ballistics)
        {

            // Call constructor and collect data from index page
            ballistics.SetBallistics(ballistics.Velocity, ballistics.Mass,
                ballistics.Diameter, ballistics.Distance, ballistics.TempFarenheit,
                ballistics.DragCoef, ballistics.WindDirection, ballistics.WindVelocityMPH);

            // contextDB.Ballistics.Add(ballistics);
            //OH GOD!!!!!

            ballistics.CalculatePressure(ballistics.TempCelcius);
            ballistics.DoBallisticsMath();
            // ballistics math must run first
            ballistics.EstimateWind();
            return View("Result", ballistics);
        }

        [HttpGet]
        [ChildActionOnly]
        public ActionResult _Results(Ballistics ballistics)
        {
           
            return PartialView("_Results", ballistics);
        }

        public BallisticsController()
        {
        }

        private class BindPropertyAttribute : Attribute
        {
        }
    }
}
