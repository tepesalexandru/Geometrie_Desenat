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
    
    public partial class Patrate : Form
    {
        public class GenericShape
        {
            public List<PointF> p = new List<PointF>();
            public Brush brushColor;
        }
        public class Square : GenericShape
        {
            
        }
        public class Triangle : GenericShape
        {

        }
        private static Graphics gfx;
        private static Random rnd = new Random();
        private List<PointF> points = new List<PointF>();
        List<Square> squares = new List<Square>();
        List<Triangle> triangles = new List<Triangle>();
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

        public Patrate()
        {
            InitializeComponent();
        }

        private void Patrate_Load(object sender, EventArgs e)
        {
            gfx = pictureBox1.CreateGraphics();
        }

        private void DrawSymmetryAxes()
        {
            foreach (Square s in squares)
            {
                for (int i = 0; i < 4; i++)
                {
                    /// Diagonal
                    gfx.DrawLine(new Pen(s.brushColor, 2), s.p[i], s.p[(i + 2) % 4]);

                    PointF start, end;
                    start = new PointF((s.p[i].X + s.p[(i + 1) % 4].X) / 2, (s.p[i].Y + s.p[(i + 1) % 4].Y) / 2);
                    end = new PointF((s.p[(i + 2) % 4].X + s.p[(i + 3) % 4].X) / 2, (s.p[(i + 2) % 4].Y + s.p[(i + 3) % 4].Y) / 2);
                    gfx.DrawLine(new Pen(s.brushColor, 2), start, end);
                }
            }
        }

        private void DrawSquares()
        {
            points.Clear();
            squares.Clear();


            for (int i = 0; i < 8; i++)
            {
                int x, y;
                x = rnd.Next(50, 400);
                y = rnd.Next(50, 400);
                PointF newP = new PointF(x, y);
                points.Add(newP);
                squares.Add(new Square());
                squares[i].p.Add(points[i]);
                int length = rnd.Next(50, 200);
                squares[i].p.Add(new PointF(newP.X + length, newP.Y));
                squares[i].p.Add(new PointF(newP.X + length, newP.Y + length));
                squares[i].p.Add(new PointF(newP.X, newP.Y + length));
            }

            

            int brushIndex = -1;

            foreach (Square s in squares)
            {
                brushIndex++;
                s.brushColor = brushes[brushIndex];
                for (int i = 0; i < 4; i++)
                {
                    gfx.FillEllipse(new SolidBrush(Color.Black), s.p[i].X - 3, s.p[i].Y - 3, 6, 6);
                    gfx.DrawLine(new Pen(brushes[brushIndex], 2), s.p[i], s.p[(i + 1) % 4]);
                }
            }
        }

        private int RandomSwapSign()
        {
            int r = rnd.Next(0, 10);
            if (r < 5) return -1;
            return 1;
        }

        private void DrawTriangles()
        {
            points.Clear();
            triangles.Clear();
            for (int i = 0; i < 5; i++)
            {
                int x, y;
                x = rnd.Next(50, 400);
                y = rnd.Next(50, 400);
                PointF newP = new PointF(x, y);
                points.Add(newP);
                triangles.Add(new Triangle());
                triangles[i].p.Add(points[i]);
                int length = rnd.Next(50, 200);
                triangles[i].p.Add(new PointF(newP.X + length, newP.Y));
                length = rnd.Next(50, 200);
                triangles[i].p.Add(new PointF(newP.X + rnd.Next(50, 100) * RandomSwapSign(), newP.Y + rnd.Next(100, 200)));
            }
            int brushIndex = -1;

            foreach (Triangle s in triangles)
            {
                brushIndex++;
                s.brushColor = brushes[brushIndex];
                for (int i = 0; i < 3; i++)
                {
                    gfx.FillEllipse(new SolidBrush(Color.Black), s.p[i].X - 3, s.p[i].Y - 3, 6, 6);
                    gfx.DrawLine(new Pen(brushes[brushIndex], 2), s.p[i], s.p[(i + 1) % 3]);
                }
            }
        }

        private void DrawPolygon()
        {
            gfx.Clear(Color.White);
            for(int i = 0; i < points.Count; i++)
            {
                gfx.FillEllipse(new SolidBrush(Color.Black), points[i].X - 3, points[i].Y - 3, 6, 6);
                gfx.DrawLine(new Pen(brushes[i % 8], 2), points[i], points[(i + 1) % points.Count]);
            }
        }

        public async void WaitSomeTime()
        {
            await Task.Delay(1000);
        }

        private void RotatePoints()
        {
            if (points.Count > 1)
            {
                PointF center = new PointF(
                    (points.Select(x => x.X).Max() + points.Select(x => x.X).Min()) / 2,
                    (points.Select(x => x.Y).Max() + points.Select(x => x.Y).Min()) / 2);

                gfx.TranslateTransform(center.X, center.Y);
                gfx.RotateTransform(0.2f);
                gfx.TranslateTransform(-center.X, -center.Y);
                DrawPolygon();
                WaitSomeTime();
                RotatePoints();
            }
            //for (int i = 0; i < points.Count; i++)
            //{
            //    PointF newP = new PointF();
            //    PointF t = newP;
            //    newP.X = (float)(points[i].X * Math.Cos(0.5) - points[i].Y * Math.Sin(0.5));
            //    newP.Y = (float)(points[i].X * Math.Sin(0.5) - points[i].Y * Math.Cos(0.5));
            //    points[i] = newP;
            //}
            //gfx.Clear(Color.White);
            //for (int i = 0; i < points.Count; i++)
            //{
            //    gfx.FillEllipse(new SolidBrush(Color.Black), points[i].X - 3, points[i].Y - 3, 6, 6);
            //    gfx.DrawLine(new Pen(brushes[(i % 8)], 2), points[i], points[(i + 1) % points.Count]);
            //}
        }

        private void DrawConvexPolygon(int nrPoints)
        {
            /// to do, from 
            points.Clear();
            GenericShape polygon = new GenericShape();
            for (int i = 0; i < nrPoints; i++)
            {
                int x, y;
                x = rnd.Next(50, 400);
                y = rnd.Next(50, 400);
                PointF newP = new PointF(x, y);
                points.Add(newP);
            }
            PointF lowerstPoint = points[0];
            int lowestIndex = 0;
            for(int i = 0; i < nrPoints; i++)
            {
                if (points[i].Y > points[lowestIndex].Y)
                {
                    lowestIndex = i;
                }
            }
            PointF aux = points[0];
            points[0] = points[lowestIndex];
            points[lowestIndex] = aux;
            points = points.OrderBy(x => Math.Atan2(x.X - points[0].X, x.Y - points[0].Y)).ToList();
            for (int i = 0; i < nrPoints; i++)
            {
                gfx.FillEllipse(new SolidBrush(Color.Black), points[i].X - 3, points[i].Y - 3, 6, 6);
                gfx.DrawLine(new Pen(brushes[(i % 8)], 2), points[i], points[(i + 1) % nrPoints]);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            gfx.Clear(Color.White);
            int nrPoints = Int32.Parse(textBox1.Text);
            DrawConvexPolygon(nrPoints);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DrawSymmetryAxes();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            RotatePoints();

        }
    }
}
