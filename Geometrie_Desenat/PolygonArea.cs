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
    public partial class PolygonArea : Form
    {
        public static Graphics gfx;
        public static Random rnd = new Random();
        List<PointF> points = new List<PointF>();
        public PolygonArea()
        {
            InitializeComponent();
        }

        private void GenerateRandomPoints(int n)
        {
            points.Clear();
            for (int i = 0; i < n; i++)
            {
                points.Add(new PointF(rnd.Next(pictureBox1.Width - 200), rnd.Next(pictureBox1.Height - 50)));
            }
        }

        private void DrawPoints()
        {
            //gfx.Clear(Color.White);
            foreach (PointF p in points)
            {
                DrawPoint(p);
            }
        }

        private void DrawPoint(PointF p)
        {
            gfx.FillEllipse(new SolidBrush(Color.DarkCyan), p.X - 7, p.Y - 7, 14, 14);
            gfx.FillEllipse(new SolidBrush(Color.LightBlue), p.X - 5, p.Y - 5, 10, 10);
        }

        private double CrossProduct(PointF a, PointF b)
        {
            return a.X * b.Y - a.Y * b.X;
        }

        public static PointF[] MakeRandomPolygon(
    int num_vertices, Rectangle bounds)
        {
            // Pick random radii.
            double[] radii = new double[num_vertices];
            const double min_radius = 0.5;
            const double max_radius = 1.0;
            for (int i = 0; i < num_vertices; i++)
            {
                radii[i] = rnd.NextDouble(min_radius, max_radius);
            }



            // Pick random angle weights.
            double[] angle_weights = new double[num_vertices];
            const double min_weight = 1.0;
            const double max_weight = 10.0;
            double total_weight = 0;
            for (int i = 0; i < num_vertices; i++)
            {
                angle_weights[i] = rnd.NextDouble(min_weight, max_weight);
                total_weight += angle_weights[i];
            }

            // Convert the weights into fractions of 2 * Pi radians.
            double[] angles = new double[num_vertices];
            double to_radians = 2 * Math.PI / total_weight;
            for (int i = 0; i < num_vertices; i++)
            {
                angles[i] = angle_weights[i] * to_radians;
            }

            // Calculate the points' locations.
            PointF[] points = new PointF[num_vertices];
            float rx = bounds.Width / 2f;
            float ry = bounds.Height / 2f;
            float cx = bounds.MidX();
            float cy = bounds.MidY();
            double theta = 0;
            for (int i = 0; i < num_vertices; i++)
            {
                points[i] = new PointF(
                    cx + (int)(rx * radii[i] * Math.Cos(theta)),
                    cy + (int)(ry * radii[i] * Math.Sin(theta)));
                theta += angles[i];
            }

            // Return the points.
            return points;
        }

        private double Area()
        {
            double sum = 0f;
            for (int i = 0; i < points.Count; i++)
            {
                sum += CrossProduct(points[i], points[(i + 1) % points.Count]);
            }
            return Math.Abs(sum) / 2f;
        }

        private void PolygonArea_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
            gfx = pictureBox1.CreateGraphics();
            gfx.Clear(Color.White);
        }

        private void drawClick_Click(object sender, EventArgs e)
        {
            int nrPoints = Int32.Parse(numberOfPointsInput.Text);
            gfx.Clear(Color.White);
            points.Clear();
            points.AddRange(MakeRandomPolygon(nrPoints, new Rectangle(0, 0, 600, 400)));
            DrawPoints();
        }

        private void drawPolygon_Click(object sender, EventArgs e)
        {
            gfx.DrawPolygon(new Pen(new SolidBrush(Color.LightBlue)), points.ToArray());
            gfx.FillPolygon(new SolidBrush(Color.LightBlue), points.ToArray());
            DrawPoints();
        }

        private void calculateArea_Click(object sender, EventArgs e)
        {
            areaBox.Items.Clear();
            areaBox.Items.Add("Aria poligonului este");
            areaBox.Items.Add("" + Area());

        }

        private void AddManualPoint()
        {
            float[] p = manualInput.Text.Split(' ').Select(float.Parse).ToArray();
            PointF newPoint = new PointF(p[0], p[1]);
            points.Add(newPoint);
            DrawPoint(newPoint);
            gfx.Clear(Color.White);
            if (points.Count >= 2)
            {

                gfx.DrawPolygon(new Pen(new SolidBrush(Color.LightBlue)), points.ToArray());
                gfx.FillPolygon(new SolidBrush(Color.LightBlue), points.ToArray());
            }
            DrawPoints();
            manualInput.Text = "";
        }

        private void addPoint_Click(object sender, EventArgs e)
        {
            AddManualPoint();
        }

        private void manualInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                AddManualPoint();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            points.Clear();
            areaBox.Items.Clear();
            gfx.Clear(Color.White);
        }
    }
    public static class RectangleExtensions
    {
        public static int MidX(this Rectangle rect)
        {
            return rect.Left + rect.Width / 2;
        }
        public static int MidY(this Rectangle rect)
        {
            return rect.Top + rect.Height / 2;
        }
        public static Point Center(this Rectangle rect)
        {
            return new Point(rect.MidX(), rect.MidY());
        }

        public static float MidX(this RectangleF rect)
        {
            return rect.Left + rect.Width / 2;
        }
        public static float MidY(this RectangleF rect)
        {
            return rect.Top + rect.Height / 2;
        }
        public static PointF Center(this RectangleF rect)
        {
            return new PointF(rect.MidX(), rect.MidY());
        }
    }
    public static class RandomExtensions
    {
        // Return a random value between 0 inclusive and max exclusive.
        public static double NextDouble(this Random rand, double max)
        {
            return rand.NextDouble() * max;
        }

        // Return a random value between min inclusive and max exclusive.
        public static double NextDouble(this Random rand,
            double min, double max)
        {
            return min + (rand.NextDouble() * (max - min));
        }
    }

}
