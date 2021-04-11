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
    public partial class SimpleConvexHull : Form
    {
        public class GenericShape
        {
            public List<PointF> p = new List<PointF>();
            public Brush brushColor;
        }
        private static Graphics gfx;
        private static Random rnd = new Random();
        private List<PointF> points = new List<PointF>();
        List<PointF> convexHull = new List<PointF>();
        List<PointF> ans = new List<PointF>();
        Brush[] brushes = new Brush[] {
            Brushes.DarkOrange,
            Brushes.Red,
            Brushes.Green,
            Brushes.YellowGreen,
            Brushes.Gold,
            Brushes.Purple,
            Brushes.Brown,
            Brushes.Black
        };
        public SimpleConvexHull()
        {
            InitializeComponent();
        }

        private void SimpleConvexHull_Load(object sender, EventArgs e)
        {
            gfx = pictureBox1.CreateGraphics();
        }

        private float CrossProduct(PointF O, PointF A, PointF B)
        {
            return (A.X - O.X) * (B.Y - O.Y)
          - (A.Y - O.Y) * (B.X - O.X);
        }

        private void BruteForceConvexHull()
        {

            int numberOfPoints = points.Count;

            int minPointIndex = 0;


            for (int i = 1; i < numberOfPoints; i++)
            {
                if (points[i].Y > points[minPointIndex].Y)
                {
                    minPointIndex = i;
                }
            }

            convexHull.Add(points[minPointIndex]);

            int pi = minPointIndex, qi = minPointIndex;
            PointF p = points[minPointIndex];
            int side = 0, j;
            do
            {
                for (int i = 0; i < numberOfPoints; i++)
                {
                    if (i == pi || i == qi)
                    {
                        continue;
                    }
                    float a, b, c;
                    PointF q = points[i];
                    a = q.Y - p.Y;
                    b = -(q.X - p.X);
                    c = (p.X * (q.Y - p.Y)) - (p.Y * (q.X - p.X));
                    int prev_side = 0;
                    for (j = 0; j < numberOfPoints; j++)
                    {
                        if (j == i || j == pi)
                        {
                            continue;
                        }

                        float val = a * points[j].X + b * points[j].Y;
                        if (val > c) side = 1;
                        else if (val == c) side = 0;
                        else side = -1;
                        if (prev_side == 0)
                        {
                            prev_side = side;
                        }
                        else if ((prev_side == 1 && side == -1) || (prev_side == -1 && side == 1))
                        {
                            break;
                        }
                    }
                    if (j == numberOfPoints && side == prev_side)
                    {
                        if (i != minPointIndex)
                        {
                            convexHull.Add(points[i]);
                        }
                        qi = pi;
                        pi = i;
                        p = points[i];
                        break;
                    }
                }
            } while (pi != minPointIndex);
        }

        public void GenerateRandomPoints(int n)
        {
            points.Clear();
            gfx.Clear(Color.White);
            for (int i = 0; i < n; i++)
            {
                points.Add(new PointF(rnd.Next(20, 600), rnd.Next(20, 500)));
                gfx.FillEllipse(new SolidBrush(Color.Black), points[i].X - 3, points[i].Y - 3, 6, 6);
            }
        }

        private void DrawHull(List<PointF> shape)
        {
            for (int i = 0; i < shape.Count; i++)
            {
                gfx.DrawLine(new Pen(brushes[1], 2), shape[i], shape[(i + 1) % shape.Count]);
            }
        }

        private void UpperLowerHull()
        {
            
            points = points.OrderBy(x => x.X).ThenBy(x => x.Y).ToList();
            List<PointF> upper = new List<PointF>();
            List<PointF> lower = new List<PointF>();
            ans.Clear();

            int numberOfPoints = points.Count;

            // Lower Hull
            for (int i = 0; i < numberOfPoints; i++)
            {
                while (ans.Count >= 2 && CrossProduct(ans[ans.Count - 2], ans[ans.Count - 1], points[i]) <= 0)
                {
                    ans.RemoveAt(ans.Count - 1);
                }
                ans.Add(points[i]);
            }
            int t = ans.Count + 1;
            for (int i = numberOfPoints - 1; i > 0; i--)
            {
                while (ans.Count >= t && CrossProduct(ans[ans.Count - 2], ans[ans.Count - 1], points[i - 1]) <= 0)
                {
                    ans.RemoveAt(ans.Count - 1);
                }
                ans.Add(points[i - 1]);
            }

            for (int i = 0; i < ans.Count; i++)
            {
                if (i < t - 2)
                {
                    gfx.DrawLine(new Pen(brushes[1], 2), ans[i], ans[(i + 1) % ans.Count]);
                } else
                {
                    gfx.DrawLine(new Pen(brushes[2], 2), ans[i], ans[(i + 1) % ans.Count]);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // int n = Int32.Parse(textBox1.Text);
            //GenerateRandomPoints(n);
            UpperLowerHull();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            float x, y;
            string[] input = textBox1.Text.Split(' ');
            x = float.Parse(input[0]) * 10;
            y = float.Parse(input[1]) * 10;
            points.Add(new PointF(x, y));
            gfx.FillEllipse(new SolidBrush(Color.Black), x - 3, y - 3, 6, 6);
        }
    }
}
