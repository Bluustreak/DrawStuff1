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
            var t = 0.000004;
            container.PInSystem.Add(new Particle(6, 4, 10, new DualVal(0, 0)));

            container.PInSystem.Add(new Particle(8, 4, 1, new DualVal(0, t)));
            container.PInSystem.Add(new Particle(4, 4, 2, new DualVal(0, -t)));
            container.PInSystem.Add(new Particle(6, 6, 3, new DualVal(-t, 0)));
            container.PInSystem.Add(new Particle(6, 2, 3, new DualVal(t, 0)));

            return container;
        }
    }
}