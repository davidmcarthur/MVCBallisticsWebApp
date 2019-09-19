using System;

namespace BallisticsConsoleDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using metric numbers ONLY for now
            // everything needs to be in METERS!!!!!!!!!
            Ballistics b = new Ballistics();

            b.diameter = .00762;    // take input of 7.62 mm and divide by 1000 to get in meters
            b.velocity = 762; // 762 m/s is 2500ft per second
            b.mass = 0.01360777; // 0.01360777 kg is 210 grains

            double area = Math.Pow(.5 * b.diameter,2) * Math.PI;

            double p = 1.225; // air density at sea level
            double coefficientDrag = .410; // that's a good bullet!
            double forceOfDrag = .5 * p * b.velocity * b.velocity * area;

            Console.WriteLine($"Area of the projectile is {area}, Drag Force is {forceOfDrag}, for initial velocity");

            Console.ReadLine();


        }
    }
    public class Ballistics
    {

        /// <summary>
        ///  INPUT PARAMS
        /// </summary>
        // speed of the projectile in meters/second

        public double velocity { get; set; }
        public double mass { get; set; }
        public double diameter { get; set; }
        public double distance { get; set; }
        public double tempFarenheit { get; set; }
        public double sAirDensity { get; set; }
        public double dragCoef { get; set; }

        // String Props
        public double meterVelocity { get; set; }
        public double areaMeters { get; set; }
        public double massKilos { get; set; }
        // density of air pressure
        public double pAirDensity { get; set; }
        // Pressure in atmospheres
        // Temperature in Celcius
        public double tempCelcius { get; set; }
        // drag Coefficient of the projectile
        //       public double dragCoefficient { get; set; }

        /*
        public string CalculatePressure(double tempCelcius)
        {
            // using defaul of 1ATM
            double pAtmospheres = 1.2;
            pAirDensity = 353.03 * (pAtmospheres / tempCelcius);
            this.sAirDensity = pAirDensity.ToString();
            return sAirDensity;
        }
        */

        /// Meters per second from feet per second.
        /// 
        public double FromFeetPerSecond(string velocity)
        {
            meterVelocity = Convert.ToDouble(velocity) * 0.3048;
            return meterVelocity;
        }

        /// Farenheight to Celcius
        /// 
        public double SetTemp(string tempFarenheit)
        {
            double t = (Convert.ToDouble(tempFarenheit));
            tempCelcius = (t - 32) * (5 / 9);
            return tempCelcius;
        }

        /// Grains to kilograms
        /// 
        public double ToKilograms(double mass)
        {
            this.massKilos = Convert.ToDouble(mass) * .0000648;
            return massKilos;
        }

        /// Area of projectile from diameter
        /// 
        public double ToArea(double diameter)
        {
            //double d = Convert.ToDouble(diameter);
            // Convert inch diameter to meter diameter
            
            // pass in projectile diameter, return area
            double radius = diameter / 2;
            areaMeters = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"running ToArea. input diameter was {diameter}, area of projectile is {areaMeters} in meters");
            return areaMeters;
        }
    }
}

