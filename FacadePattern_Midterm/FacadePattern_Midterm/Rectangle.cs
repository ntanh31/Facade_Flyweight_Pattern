using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FacadePattern_Midterm
{
    class Rectangle : IShape
    {
        Graphics graphics;
        Pen pen;
        SolidBrush brush;
        float x, y, height, width;

        public Rectangle(Graphics g, Pen p, SolidBrush sb, float x, float y, float height, float width)
        {
            this.graphics = g;
            this.pen = p;
            this.brush = sb;
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
        }

        public void Draw()
        {
            graphics.DrawRectangle(pen, x, y, width, height);
        }

        public void Fill()
        {
            graphics.FillRectangle(brush, x, y, width, height);
        }
    }
}
