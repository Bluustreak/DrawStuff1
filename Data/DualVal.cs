using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawStuff1.Models
{
    public class DualVal
    {
        public DualVal()
        {
        }

        public DualVal(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }    

    }
}
