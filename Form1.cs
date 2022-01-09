using DrawStuff1.Data;
using DrawStuff1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawStuff1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
     
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Initialize init = new Initialize();
            PContainer cont = init.InitPinContainer();
            cont.drawContents(e);

            DrawingTools DT = new DrawingTools();

            //---the simulation loop---//

            DualVal accXY = new DualVal(0, 0);
            //the amount of simulation ticks
            for (int TS = 1; TS < 5; TS++)
            {
                accXY.X = 0;
                accXY.Y = 0; 
                //this loop calculates all the interactions
                foreach (Particle a in cont.PInSystem)
                {
                    foreach (Particle b in cont.PInSystem) // this loop checks the acceleration strength to/from all the other partciles and sums it
                    {
                        if (a!=b)
                        {
                            var temp = CustomMaths.CalcAccelXY(a, b, "gravity");
                            accXY.X += temp.X;
                            accXY.Y += temp.Y;
                        }
                    }

                    DualVal XYdisp = CustomMaths.DispDueAccel(a,TS,accXY);
                    a.CurrentXY.X+=XYdisp.X;
                    a.CurrentXY.Y+=XYdisp.Y;
                    a.speedXY.X+=XYdisp.X/TS;
                    a.speedXY.Y+=XYdisp.Y/TS;
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine(a.speedXY.X);

                }

                // and this updates the view


                DT.ScreenClear(e);
                cont.drawContents(e);
            }
            //---the simulation loop---//
        }
    }
}
