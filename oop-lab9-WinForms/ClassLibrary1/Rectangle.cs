using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Rectangle : Line
    {
        protected int height;
        public int Height { get; set; }
        public Rectangle() : base()
        {
            height = rnd.Next(200);
            width = rnd.Next(200);
        }
        public Rectangle(Color colour, int x1, int y1, int x2, int y2, int height) : base(colour, x1, y1, x2, y2)
        {
            this.height = height;
        }
        public Rectangle(Color colour, int x1, int y1, int x2, int y2) : base(colour, x1, y1, x2, y2)
        { 
            height = rnd.Next(200); 
        }
        public Rectangle(Rectangle duplicate) : base (duplicate)
        {
            duplicate.height = height;
        }
        public override void Draw(Graphics g)
        {
            new System.Drawing.Rectangle(0, 0, 400, 400);
            SolidBrush brush = new SolidBrush(Colour);
            g.FillRectangle(brush, x1, y1, width, height);
        }
    }
}
