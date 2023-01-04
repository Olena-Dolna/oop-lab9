using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using Point = ClassLibrary1.Point;
using Rectangle = ClassLibrary1.Rectangle;

namespace oop_lab9_WinForms
{
    public partial class Form1 : Form
    {
        protected Graphics g;
        protected Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Drawing();  
        }
        private void Drawing()
        {
            g = DisplayBox.CreateGraphics();
            Shape[] shapes = new Shape[20];
            for (int i = 0; i < shapes.Length; i++)
            {
                switch (random.Next(6))
                {
                    case 1:
                        shapes[i] = new Rectangle();
                        shapes[i].Draw(g);
                        break;
                    case 2:
                        shapes[i] = new Circle();
                        shapes[i].Draw(g);
                        break;
                    case 3:
                        shapes[i] = new Ellipse();
                        shapes[i].Draw(g);
                        break;
                    case 4:
                        shapes[i] = new Line();
                        shapes[i].Draw(g);
                        break;
                    case 5:
                        shapes[i] = new Point();
                        shapes[i].Draw(g);
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayBox.Image = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
