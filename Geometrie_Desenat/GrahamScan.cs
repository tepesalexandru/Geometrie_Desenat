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
    public partial class GrahamScan : Form
    {
        private static Graphics gfx;
        private static Random rnd = new Random();
        private List<PointF> points = new List<PointF>();
        List<PointF> stivaGraham = new List<PointF>();
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
        public GrahamScan()
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
                gfx.FillEllipse(new SolidBrush(Color.Black), p.X - 3, p.Y - 3, 6, 6);
            }
        }

        private void DrawHull()
        {
            for (int i = 0; i < stivaGraham.Count - 1; i++)
            {
                gfx.DrawLine(new Pen(brushes[i % 8], 4), stivaGraham[i], stivaGraham[i + 1]);
            }
            gfx.DrawLine(new Pen(brushes[0], 4), stivaGraham[stivaGraham.Count - 1], stivaGraham[0]);
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
            FindLowestPoint();
            SortPointsByAngle(points[0]);
            stivaGraham.Add(points[0]);
            stivaGraham.Add(points[1]);
            for (int i = 2; i < points.Count; i++)
            {
                while (stivaGraham.Count > 1 && !IsCounterClockwiseTurn(stivaGraham[stivaGraham.Count - 2], stivaGraham[stivaGraham.Count - 1], points[i]))
                {
                    stivaGraham.RemoveAt(stivaGraham.Count - 1);
                }
                stivaGraham.Add(points[i]);
            }
        }

        private void GrahamScan_Load(object sender, EventArgs e)
        {
            gfx = pictureBox1.CreateGraphics();
        }

        private void drawPoints_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textNumarPuncte.Text);
            GenerateRandomPoints(n);
            Graham();
            DrawPoints();
            DrawHull();
        }
    }
}
