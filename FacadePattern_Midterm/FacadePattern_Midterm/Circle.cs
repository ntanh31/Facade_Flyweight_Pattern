using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FacadePattern_Midterm
{
    class Circle : IShape
    {
        Graphics graphics;
        Pen pen;
        SolidBrush brush;
        float centerX, centerY, radius;

        public Circle(Graphics g, Pen p, SolidBrush br, float cX, float cY, float rad)
        {
            this.graphics = g;
            this.pen = p;
            this.brush = br;
            this.centerX = cX;
            this.centerY = cY;
            this.radius = rad;
        }

        void IShape.Draw()
        {
            graphics.DrawEllipse(pen, centerX - radius, centerY - radius, radius + radius, radius + radius);
        }

        void IShape.Fill()
        {
            graphics.FillEllipse(brush, centerX - radius, centerY - radius, radius + radius, radius + radius);
        }
    }
}
