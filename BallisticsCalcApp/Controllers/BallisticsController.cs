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

        // GET: Ballistics/Create
        [HttpPost]
        public ActionResult Result(Ballistics ballistics)
        {
            // contextDB.Ballistics.Add(ballistics);
            //OH GOD!!!!!
            ballistics.SetBallistics(ballistics.Velocity, ballistics.Mass, ballistics.Diameter, ballistics.Distance, ballistics.TempFarenheit, ballistics.DragCoef);
            
            ballistics.CalculatePressure(ballistics.TempCelcius);
            ballistics.DoBallisticsMath();


            return View("Result", ballistics);
        }
        public BallisticsController()
        {
        }

        private class BindPropertyAttribute : Attribute
        {
        }
    }
}
