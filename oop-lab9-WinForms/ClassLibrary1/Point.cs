using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Point : Shape
    {

        protected int x1;
        protected int y1; 
        protected int width;
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int Width { get; set; }
        public Point(Color colour, int x1, int y1) : base(colour)
        {
            this.x1 = x1;
            this.y1 = y1;
        }
        public Point() : base()
        {
            x1 = rnd.Next(200);
            y1 = rnd.Next(200);
            width = rnd.Next(4);
        }
        public Point(Color colour) : base (colour)
        {
            x1 = rnd.Next(200);
            y1 = rnd.Next(200);
            width = rnd.Next(4);
        }
        public Point(Point duplicate) : base (duplicate)
        {
            x1 = duplicate.x1;
            y1 = duplicate.y1;
            width = duplicate.width;
        }
        public override void Draw(Graphics g)
        {
            new System.Drawing.Rectangle(0, 0, 400, 400);
            SolidBrush brush = new SolidBrush(Colour) ;
            g.FillEllipse(brush, x1, y1, width, width);
        }

    }
}
