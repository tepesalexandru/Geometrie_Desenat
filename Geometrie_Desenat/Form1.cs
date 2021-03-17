using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometrie_Desenat
{
    public partial class Form1 : Form
    {
        private static Graphics gfx;
        public Form1()
        {
            InitializeComponent();
        }

        private List<PointF> points = new List<PointF>();

        private void Form1_Load(object sender, EventArgs e)
        {
            gfx = pictureBox1.CreateGraphics();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gfx.Clear(Color.White);
            PointF newPoint = new PointF();
            string[] text = textBox1.Text.Split(new[] { ' ' });
            newPoint.X = Int32.Parse(text[0]);
            newPoint.Y = Int32.Parse(text[1]);

            points.Add(newPoint);
            foreach (var p in points)
            {
                gfx.FillEllipse(new SolidBrush(Color.Black), p.X, p.Y, 2, 2);
            }

            for (int i = 1; i < points.Count; i++)
            {
                gfx.DrawLine(Pens.Black, points[i], points[i - 1]);
            }

            int len = points.Count;

            gfx.DrawLine(Pens.Black, points[len - 1], points[0]);

            textBox1.Text = "";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int len = points.Count;
            for (int i = 0; i < len; i++)
            {
                PointF p1 = points[(i + 1) % 3];
                PointF p2 = points[(i + 2) % 3];

                PointF p0 = points[i];

                gfx.FillEllipse(new SolidBrush(Color.Red), p0.X, p0.Y, 2, 2);
                gfx.DrawLine(new Pen(Brushes.Red, 2), p0, new PointF((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int len = points.Count;
            for (int i = 0; i < len; i++)
            {
                PointF p1 = points[(i + 1) % 3];
                PointF p2 = points[(i + 2) % 3];

                PointF p0 = points[i];
                float t = (p0.X - p1.X) * (p2.X - p1.X) + (p0.Y - p1.Y) * (p2.Y - p1.Y);
                t = t / ((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
                PointF p4 = new PointF();
                p4.X = p1.X + t * (p2.X - p1.X);
                p4.Y = p1.Y + t * (p2.Y - p1.Y);
                gfx.FillEllipse(new SolidBrush(Color.Red), p4.X, p4.Y, 2, 2);
                gfx.DrawLine(new Pen(Brushes.Green, 2), p0, p4);
            }
        }
    }
}
