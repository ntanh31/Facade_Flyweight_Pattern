using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FacadePattern_Midterm
{
    class ShapeMaker
    {
        private IShape circle;
        private IShape triangle;
        private IShape rectangle;

        public ShapeMaker(Circle cir, Triangle tri, Rectangle rec)
        {
            circle = cir;
            triangle = tri;
            rectangle = rec;
        }

        public void DrawCircle()
        {
            circle.Draw();
        }

        public void FillCircle()
        {
            circle.Fill();
        }
        
        public void DrawTriangle()
        {
            triangle.Draw();
        }

        public void FillTriangle()
        {
            triangle.Fill();
        }

        public void DrawRectangle()
        {
            rectangle.Draw();
        }

        public void FillRectangle()
        {
            rectangle.Fill();
        }
    }
}
