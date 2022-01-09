using DrawStuff1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawStuff1.Data
{
    public class Initialize
    {
        public PContainer InitPinContainer()
        {
            PContainer container = new PContainer(100, 100, 500, 500);


            //int width = 10, height = 10, spacing = 5;

            //for (int i = container.x1+spacing;
            //    i < container.x2-spacing;
            //    i+=(container.x2 - container.x1)/width)
            //{
            //    for (int j = container.y1 + spacing;
            //    j < container.y2 - spacing;
            //    j += (container.y2 - container.y1) / height)
            //    {
            //        Particle P = new Particle(i*30, j*30, 10);
            //        if (P.CurrentXY.X + P.Radius > container.x1 &&
            //            P.CurrentXY.X + P.Radius < container.x2 &&
            //            P.CurrentXY.Y + P.Radius > container.y1 &&
            //            P.CurrentXY.Y + P.Radius < container.y2)
            //        {
            //            //if the particle is within the borders of the container, accept it to the list of P in system
            //            container.PInSystem.Add(P);
            //        }
            //    }
            //}
            container.PInSystem.Add(new Particle(500, 500, 10, new DualVal(0, 0)));
            container.PInSystem.Add(new Particle(530, 700, 10, new DualVal(0, 0)));

            //for (int i = 100; i < 1000-50; i+=300)
            //{
            //    for (int j = 100; j < 500-50; j+=300)
            //    {
            //        Particle P = new Particle(i, j, 10, new DualVal(0,0));
            //        container.PInSystem.Add(P);
            //    }
            //}


            return container;
        }
    }
}