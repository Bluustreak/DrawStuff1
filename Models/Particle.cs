using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawStuff1.Models
{
    public class Particle
    {
        public DualVal CurrentXY { get; set; }
        public int Mass { get; set; }
        public float Radius { get; set; }
        public DualVal speedXY { get; set; }

        List<DualVal> DualValdinateHistory = new List<DualVal>();  

        
        public Particle(double x, double y, int mass, DualVal sXY)
        {
            CurrentXY = new DualVal(x, y);
            DualValdinateHistory.Add(CurrentXY);    
            Mass = mass;
            Radius = (float)Math.Pow(mass, 1/3F);
            // the sphere volume formula is used to extract the radius. mass is assumed to be volume.
            //mass/density=4/3 * pi * r^3
            //mass/density=4/3 * pi * r^3
            speedXY = sXY;
        }
    }
}
