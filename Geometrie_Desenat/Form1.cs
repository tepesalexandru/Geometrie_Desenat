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

        Bitmap bmp;
        Graphics grp;
        static Random rnd = new Random();
        public class point
        {
            public float x, y;
            public point()
            {
                x = rnd.Next(900);
                y = rnd.Next(600);
            }
            public void Draw(Graphics grp)
            {
                grp.DrawEllipse(new Pen(Color.Red, 2), x, y, 2, 2);
            }
        }

        private List<point> points = new List<point>();

        private void Form1_Load(object sender, EventArgs e)
        {
            gfx = pictureBox1.CreateGraphics();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gfx.Clear(Color.White);
            point newPoint = new point();
            string[] text = textBox1.Text.Split(new[] { ' ' });
            newPoint.x = Int32.Parse(text[0]);
            newPoint.y = Int32.Parse(text[1]);

            points.Add(newPoint);
            foreach(var p in points)
            {
                gfx.FillEllipse(new SolidBrush(Color.Black), p.x, p.y, 2, 2);
            }

            for (int i = 1; i < points.Count; i++)
            {
                gfx.DrawLine(Pens.Black, points[i].x, points[i].y, points[i - 1].x, points[i - 1].y);
            }

            int len = points.Count;

            gfx.DrawLine(Pens.Black, points[len - 1].x, points[len - 1].y, points[0].x, points[0].y);

            textBox1.Text = "";
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int len = points.Count;
            for (int i = 0; i < len; i++)
            {
                point p1 = points[(i + 1) % 3];
                point p2 = points[(i + 2) % 3];

                point p0 = points[i];

                gfx.FillEllipse(new SolidBrush(Color.Red), p0.x, p0.y, 2, 2);
                gfx.DrawLine(Pens.Red, p0.x, p0.y, (p1.x + p2.x) / 2, (p1.y + p2.y) / 2);
            }
        }
    }
}
