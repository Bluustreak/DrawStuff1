using DrawStuff1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawStuff1.Data
{
    public static class CustomMaths
    {
        public static double Gconst = 6.67 * (Math.Pow(10, -11));
        public static DualVal DiffXY(Particle p1, Particle p2)
        {
            double
                dx = p1.CurrentXY.X - p2.CurrentXY.X,
                dy = p1.CurrentXY.Y - p2.CurrentXY.Y;
            DualVal result = new DualVal(dx, dy);
            return result;
        }
        public static double Hypotenuse(Particle p1, Particle p2)
        {
            var dxy = DiffXY(p1, p2);
            double result = Math.Sqrt(Math.Pow(dxy.X, 2) + Math.Pow(dxy.Y, 2));
            return result;
        }
        public static double Hypotenuse(double x1, double y1, double x2, double y2)
        {
            double result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            return result;
        }
        public static DualVal CalcAccelXY(Particle p1, Particle p2, string type) //acceleration in m/s^2, not force!
        {
            DualVal result = new DualVal();
            if (type == "gravity")
            {
                double hypoDist = Hypotenuse(p1, p2);
                double absForce = ((p1.Mass * p2.Mass * Gconst) / Math.Pow(hypoDist, 2));

                double AccelX = (absForce * (DiffXY(p1, p2).X / Hypotenuse(p1, p2)))/p1.Mass;
                double AccelY = (absForce * (DiffXY(p1, p2).Y / Hypotenuse(p1, p2)))/p1.Mass;

                result = new DualVal(AccelX, AccelY);
            }
            
            return result;
        }
        public static DualVal DispDueAccel(Particle p1, double TS, DualVal AccelXY)
        {            
            double dispX = p1.speedXY.X * TS + ((1 / (double)2)) * AccelXY.X + Math.Pow(TS,2);
            double dispY = p1.speedXY.Y * TS + ((1 / (double)2)) * AccelXY.Y + Math.Pow(TS,2);
            //s = ut + (1/2)at^2

            DualVal result = new DualVal(dispX, dispY);
            return result;
        }


    }
}
