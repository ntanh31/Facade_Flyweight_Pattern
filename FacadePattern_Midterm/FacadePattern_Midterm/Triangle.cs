using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FacadePattern_Midterm
{
    class Triangle : IShape
    {
        Graphics graphics;
        Pen pen;
        SolidBrush brush;
        Point point1, point2, point3;
        public Triangle(Graphics g, Pen p, SolidBrush sb, Point p1, Point p2, Point p3)
        {
            this.graphics = g;
            this.pen = p;
            this.brush = sb;
            this.point1 = p1;
            this.point2 = p2;
            this.point3 = p3;
        }
        public void Draw()
        {
            Point[] p = { point1, point2, point3};
            graphics.DrawPolygon(pen, p);
        }

        public void Fill()
        {
            Point[] p = { point1, point2, point3 };
            graphics.FillPolygon(brush, p);
        }
    }
}
