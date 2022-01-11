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
            cont.DrawBoundry(e);

//---the simulation loop---//

DualVal accXY = new DualVal(0, 0);
            byte drag = 0;
            //the amount of simulation ticks
            double TS = 100;
            for(int counter = 0; counter <100000; counter ++)
            {
                
                //this loop calculates all the interactions
                foreach (Particle a in cont.PInSystem)
                {
                    accXY.X = 0;
                    accXY.Y = 0;
                    bool ShouldCalculate = false;
                    foreach (Particle b in cont.PInSystem) // this loop checks the acceleration strength to/from all the other partciles and sums it
                    {
                        if (a!=b)
                        {
                            ShouldCalculate = true;
                            var temp = CustomMaths.CalcAccelXY(a, b, "gravitywPushback");
                            accXY.X += temp.X;
                            accXY.Y += temp.Y;
                            

                        }
                        //Console.WriteLine(accXY.X+" "+accXY.Y);
                    }
                    if(ShouldCalculate)
                    {
                        counter++;
                        DualVal XYdisp = CustomMaths.DispDueAccel(a, TS, accXY);
                        //Console.WriteLine("current particle XY:" + a.CurrentXY.X + " " + a.CurrentXY.Y + "with disp towards XY: " + XYdisp.X + " " + XYdisp.Y);

                        a.CurrentXY.X += XYdisp.X;
                        a.CurrentXY.Y += XYdisp.Y;
                        a.speedXY.X = (XYdisp.X / TS) - drag * (Math.Sign(XYdisp.X) * 1 * Math.Pow(a.speedXY.X, 2));
                        a.speedXY.Y = (XYdisp.Y / TS) - drag * (Math.Sign(XYdisp.Y) * 1 * Math.Pow(a.speedXY.Y, 2));
                    }

                    if (true) // if the sim should be ran inside a boundary box
                    {
                        // when colliding with a wall, the particle looses some% of its speed
                        double dampening = 0.7;
                        if (a.CurrentXY.X < cont.x1)
                        {
                            a.speedXY.X *= -dampening;
                            a.CurrentXY.X = cont.x1;
                        }
                        else if (a.CurrentXY.X > cont.x2)
                        {
                            a.speedXY.X *= -dampening;
                            a.CurrentXY.X = cont.x2;
                        }

                        if (a.CurrentXY.Y < cont.y1)
                        {
                            a.speedXY.Y *= -dampening;
                            a.CurrentXY.Y = cont.y1;
                        }
                        else if (a.CurrentXY.Y > cont.y2)
                        {
                            a.speedXY.Y *= -dampening;
                            a.CurrentXY.Y = cont.y2;
                        }
                    }
                }

                // and this updates the view

                //System.Threading.Thread.Sleep(1);
                //if (counter>10000)
                //{
                //    counter = 0;
                //    DT.ScreenClear(e);
                //}
                    
                cont.drawContents(e);
            }
            //---the simulation loop---//
        }
    }
}
