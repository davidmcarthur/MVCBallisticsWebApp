using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BallisticsCalcApp.Models
{
    public class BallisticsInitializer
    {
        public void Initialize() {

            /// Default Values for ballistics calculator.
            /// TODO  Need to seed to Index somehow?
            var b = new Models.Ballistics()
            {
                Diameter = ".308",
                Mass = "175",
                Velocity = "2200",
                TempFarenheit = "68",
                Distance = "100",
                DoubleDragCoef = .470,
                pAirDensity = 6.229941176470588,
                DoubleMeterVelocity = 670.56,
                DoubleAreaMeters = 0.0000480439297184
            };
        }
    }
}