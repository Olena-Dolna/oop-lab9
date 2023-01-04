using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Line : Point
    {
        protected int x2;
        protected int y2;
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public Line() : base()
        {
            x2 = rnd.Next(300);
            y2 = rnd.Next(300);
        }
        public Line(Color colour, int x1, int y1, int x2, int y2) : base(colour, x1, y1)
        {
            this.x2 = x2;
            this.y2 = y2;
        }
        public Line(Color colour, int x1, int y1, int x2) :  base (colour, x1, y1)
        {
            this.x2 = x2;
            y2 = rnd.Next(300);
        }
        public Line(Line duplicate) : base (duplicate)
        {
            this.x2 = duplicate.x2;
            this.y2 = duplicate.y2;
        }
        public override void Draw(Graphics g)
        {
            new System.Drawing.Rectangle(0, 0, 400, 400);
            SolidBrush brush = new SolidBrush(Colour);
            Pen pen = new Pen(brush, width);
            g.DrawLine(pen, x1, y1, x2, y2);
        }
    }
}
