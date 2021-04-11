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
    public partial class Graham_And_Jarvis : Form
    {
        private static Graphics gfx;
        private static Random rnd = new Random();
        private List<PointF> points = new List<PointF>();
        List<PointF> hull = new List<PointF>();
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
        public Graham_And_Jarvis()
        {
            InitializeComponent();
        }

        private void GenerateRandomPoints(int numberOfPoints)
        {
            int i;
            points.Clear();
            for (i = 0; i < numberOfPoints; i++)
            {
                PointF newPoint = new PointF(rnd.Next(20, 700), rnd.Next(20, 500));
                points.Add(newPoint);
            }
        }

        private void DrawPoints()
        {
            gfx.Clear(Color.White);
            foreach (PointF p in points)
            {
                DrawPoint(p);
            }
        }

        private void DrawPoint(PointF p)
        {
            gfx.FillEllipse(new SolidBrush(Color.Black), p.X - 7, p.Y - 7, 14, 14);
            gfx.FillEllipse(new SolidBrush(Color.Red), p.X - 5, p.Y - 5, 10, 10);

        }

        private void Drawhull()
        {
            for (int i = 0; i < hull.Count - 1; i++)
            {
                gfx.DrawLine(new Pen(brushes[i % 8], 4), hull[i], hull[i + 1]);
            }
            gfx.DrawLine(new Pen(brushes[0], 4), hull[hull.Count - 1], hull[0]);
        }

        private void FindLowestPoint()
        {
            int lowestPointIndex = 0;
            for (int i = 1; i < points.Count; i++)
            {
                if (points[i].Y > points[lowestPointIndex].Y)
                {
                    lowestPointIndex = i;
                }
                else if (points[i].Y == points[lowestPointIndex].Y)
                {
                    if (points[i].X < points[lowestPointIndex].X)
                    {
                        lowestPointIndex = i;
                    }
                }
            }
            PointF aux = points[lowestPointIndex];
            points[lowestPointIndex] = points[0];
            points[0] = aux;
        }

        private int GetTurnType(PointF a, PointF b, PointF c)
        {
            float area = (b.X - a.X) * (c.Y - a.Y) - (b.Y - a.Y) * (c.X - a.X);
            if (area < 0) return -1; // counterclockwise
            if (area > 0) return 1; // clockwise
            return 0; // collinear
        }

        private bool IsCounterClockwiseTurn(PointF a, PointF b, PointF c)
        {
            return GetTurnType(a, b, c) == -1;
        }

        private void SortPointsByAngle(PointF center)
        {
            List<PointF> sortedPoints = points.GetRange(1, points.Count - 1).OrderBy(p => -Math.Atan2(p.Y - center.Y, p.X - center.X)).ToList();
            PointF firstPoint = points[0];
            points.Clear();
            points.Add(firstPoint);
            points.AddRange(sortedPoints);
        }

        private void Graham()
        {
            hull.Clear();
            FindLowestPoint();
            SortPointsByAngle(points[0]);
            hull.Add(points[0]);
            hull.Add(points[1]);
            for (int i = 2; i < points.Count; i++)
            {
                while (hull.Count > 1 && !IsCounterClockwiseTurn(hull[hull.Count - 2], hull[hull.Count - 1], points[i]))
                {
                    hull.RemoveAt(hull.Count - 1);
                }
                hull.Add(points[i]);
            }
        }

        private void Jarvis()
        {
            hull.Clear();
            FindLowestPoint();
            hull.Add(points[0]);
            PointF previous = points[0];
            while (true)
            {
                PointF next = new PointF();
                next.X = -1;
                next.Y = -1;
                foreach (PointF p in points)
                {
                    if (p.X == previous.X && p.Y == previous.Y) continue;
                    if (next.X == -1 && next.Y == -1)
                    {
                        next = p;
                        continue;
                    }

                    if (IsCounterClockwiseTurn(previous, next, p))
                    {
                        next = p;
                    }
                }
                if (next.X == points[0].X && next.Y == points[0].Y) break;
                hull.Add(next);
                previous = next;
            }
        }

        private double CrossProduct(PointF a, PointF b)
        {
            return a.X * b.Y - a.Y * b.X;
        }

        private double Area()
        {
            double sum = 0f;
            for (int i = 0; i < hull.Count; i++)
            {
                sum += CrossProduct(hull[i], hull[(i + 1) % hull.Count]);
            }
            return Math.Abs(sum) / 2f;
        }

        private void GrahamScan_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
            gfx = pictureBox1.CreateGraphics();
            gfx.Clear(Color.White);
        }

        private void drawGraham_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textNumarPuncte.Text);
            GenerateRandomPoints(n);
            Graham();
            DrawPoints();
            Drawhull();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Graham();
            Drawhull();
        }
        private void drawJarvis_Click(object sender, EventArgs e)
        {
            Jarvis();
            Drawhull();
        }

        private void generateRandom_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textNumarPuncte.Text);
            GenerateRandomPoints(n);
            DrawPoints();
        }

        private void addPoint_Click(object sender, EventArgs e)
        {
            string[] s = textPuncteManual.Text.Split(' ');
            float x = float.Parse(s[0]);
            float y = float.Parse(s[1]);
            PointF p = new PointF(x, y);
            points.Add(p);
            DrawPoint(p);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            points.Clear();
            gfx.Clear(Color.White);
            hull.Clear();
        }
    }
}
