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

namespace DrawStuff1.Data
{
    public class DrawingTools
    {
        Pen blackPen = new Pen(Color.FromArgb(5, 50, 50, 50),5);
        //System.Drawing.SolidBrush BlackPen = new SolidBrush(Color.DarkGreen);
        public void drawCircleAt(int x, int y, PaintEventArgs e, float size, float mass)
        {
            //y = y*(-1);
            Rectangle circle = new Rectangle(x, y, 10, 10);
            circle.X = circle.X - circle.Width / 2;
            circle.Y = circle.Y - circle.Height / 2;
            blackPen.Width = size;
            blackPen.Color = Color.FromArgb(50, 255-(int)mass,120, (int)mass);
            e.Graphics.DrawEllipse(blackPen, circle);
            
        }
        

        public void ScreenClear(PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
        }
        public void ScreenMatting(PaintEventArgs e)
        {
            //e.Graphics.Clear(Color.FromArgb(100));
        }
    }
}
