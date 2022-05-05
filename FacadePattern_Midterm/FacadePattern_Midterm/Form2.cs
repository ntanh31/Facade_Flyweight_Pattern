using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacadePattern_Midterm
{
    public partial class Form2 : Form
    {
        Form1 form1;
        private float xCircle;
        private float yCircle;
        private float radius;
        private Point p1;
        private Point p2;
        private Point p3;
        private float xRec;
        private float yRec;
        private float width;
        private float height;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        public Form2(Form1 form1, float xCircle, float yCircle, float radius, Point p1, Point p2, Point p3, float xRec, float yRec, float width, float height) : this(form1)
        {
            InitializeComponent();
            this.xCircle = xCircle;
            this.yCircle = yCircle;
            this.radius = radius;
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.xRec = xRec;
            this.yRec = yRec;
            this.width = width;
            this.height = height;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            ShapeMaker sm = new ShapeMaker(new Circle(e.Graphics, new Pen(Color.Green), new SolidBrush(Color.Green), xCircle, yCircle, radius),
                new Triangle(e.Graphics, new Pen(Color.Green), new SolidBrush(Color.Blue), p1, p2, p3),
                new Rectangle(e.Graphics, new Pen(Color.Red), new SolidBrush(Color.Red), xRec, yRec, height, width));

            sm.DrawCircle();
            sm.FillCircle();

            sm.DrawTriangle();
            sm.FillTriangle();

            sm.DrawRectangle();
            sm.FillRectangle();
        }
    }
}
