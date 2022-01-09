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
            PContainer container = new PContainer(0, 0, 8, 6);
            var t = 0.00001;

            container.PInSystem.Add(new Particle(2, 5, 1, new DualVal(0, -t)));
            container.PInSystem.Add(new Particle(8, 5, 1, new DualVal(0, t)));
            container.PInSystem.Add(new Particle(5, 8, 1, new DualVal(0, t)));


            //container.PInSystem.Add(new Particle(1, 1, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(2, 1, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(3, 1, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(4, 1, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(5, 1, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(6, 1, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(7, 1, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(8, 1, 100, new DualVal(0, t)));

            //container.PInSystem.Add(new Particle(1, 2, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(2, 2, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(3, 2, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(4, 2, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(5, 2, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(6, 2, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(7, 2, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(8, 2, 100, new DualVal(0, t)));

            //container.PInSystem.Add(new Particle(1, 3, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(2, 3, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(3, 3, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(4, 3, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(5, 3, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(6, 3, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(7, 3, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(8, 3, 100, new DualVal(0, t)));

            //container.PInSystem.Add(new Particle(1, 4, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(2, 4, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(3, 4, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(4, 4, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(5, 4, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(6, 4, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(7, 4, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(8, 4, 100, new DualVal(0, t)));

            //container.PInSystem.Add(new Particle(1, 5, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(2, 5, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(3, 5, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(4, 5, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(5, 5, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(6, 5, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(7, 5, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(8, 5, 100, new DualVal(0, t)));

            //container.PInSystem.Add(new Particle(1, 6, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(2, 6, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(3, 6, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(4, 6, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(5, 6, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(6, 6, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(7, 6, 100, new DualVal(0, t)));
            //container.PInSystem.Add(new Particle(8, 6, 100, new DualVal(0, t)));


            return container;
        }
    }
}