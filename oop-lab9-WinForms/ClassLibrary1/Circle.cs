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
    public class Circle : Point
    {
        protected int radius;
        public int Radius { get; set; }
        public Circle() : base()
        {
            radius = rnd.Next(200);
        }
        public Circle(Color colour, int x1, int y1, int radius) : base(colour, x1, y1)
        {
            this.radius = radius;
        }
        public Circle(Color colour, int x1, int y1) : base(colour, x1, y1)
        {
            radius = rnd.Next(200);
        }
        public Circle(Circle duplicate) : base(duplicate)
        {
            radius = duplicate.Radius;
        }
        public override void Draw(Graphics g)
        {
            new System.Drawing.Rectangle(0, 0, 400, 400);
            SolidBrush brush = new SolidBrush(Colour);
            g.FillEllipse(brush, x1, y1, radius, radius);
        }
    }
}
