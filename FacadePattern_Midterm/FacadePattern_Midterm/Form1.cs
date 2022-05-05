using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FacadePattern_Midterm
{
    public partial class Form1 : Form
    {
        float xCircle, yCircle, radius;
        float xRec, yRec, width, height;
        Point p1, p2, p3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_draw_Click(object sender, EventArgs e)
        {
            xCircle = float.Parse(tb_xCircle.Text);
            yCircle = float.Parse(tb_yCircle.Text);
            radius = float.Parse(tb_Radius.Text);
            xRec = float.Parse(tb_xRec.Text);
            yRec = float.Parse(tb_yRec.Text);
            width = float.Parse(tb_Rong.Text);
            height = float.Parse(tb_Dai.Text);
            p1 = new Point(int.Parse(tb_x1.Text), int.Parse(tb_y1.Text));
            p2 = new Point(int.Parse(tb_x2.Text), int.Parse(tb_y2.Text));
            p3 = new Point(int.Parse(tb_x3.Text), int.Parse(tb_y3.Text));


            Form2 form2 = new Form2(this, xCircle, yCircle, radius, p1, p2, p3, xRec, yRec, width, height);
            form2.ShowDialog();
        }
    }
}
