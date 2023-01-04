using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Shape
    {
        public static Random rnd = new Random();
        public Color Colour { get; set; }
        public Shape(Color colour)
        {
            Colour = colour;
        }
        public Shape()
        {
            Colour = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }
        public Shape(Shape duplicate)
        {
            Colour = duplicate.Colour;
        }
        public abstract void Draw(Graphics g);
    }
}
