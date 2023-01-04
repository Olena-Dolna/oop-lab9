using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Ellipse : Circle
    {
        protected int radius2;
        public int Radius2 { get; set; }
        public Ellipse() : base()
        {
            radius2 = rnd.Next(200);
        }
        public Ellipse(Color colour, int x1, int y1, int radius, int radius2) : base(colour, x1, y1, radius)
        {
            this.radius2 = radius2;
        }
        public Ellipse(Color colour, int x1, int y1, int radius) : base(colour, x1, y1, radius)
        {
            radius2 = rnd.Next(200);
        }
        public Ellipse(Ellipse duplicate) : base (duplicate)
        {
            radius2 = duplicate.radius2;
        }
        public override void Draw(Graphics g)
        {
            new System.Drawing.Rectangle(0, 0, 400, 400);
            SolidBrush brush = new SolidBrush(Colour);
            g.FillEllipse(brush, x1, y1, radius, radius2);
        }

    }
}
