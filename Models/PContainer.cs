using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrawStuff1.Models;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DrawStuff1.Data;

namespace DrawStuff1.Models
{
    public class PContainer // A physical Particle Container
    {
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
        //Upper left corner and lower right corner

        public List<Particle> PInSystem { get; set; }

        
        Pen blackPen = new Pen(Color.Black, 3);
        System.Drawing.SolidBrush BlackPen = new SolidBrush(Color.Black);
        public void drawContents(PaintEventArgs e)
        {
            DrawingTools DT = new DrawingTools();
            for (int i = 0; i < PInSystem.Count(); i++)
            {
                var currEl = PInSystem.ElementAt(i);
                int drawX = (int)(currEl.CurrentXY.X * 100);
                int drawY = (int)(currEl.CurrentXY.Y * 100);
                DT.drawCircleAt(drawX, drawY, e);
                
            }
        }



        public PContainer(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            PInSystem = new List<Particle>();
        }
    }
}
