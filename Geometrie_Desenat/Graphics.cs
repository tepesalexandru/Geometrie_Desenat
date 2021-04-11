using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public static class myGraphics
    {
        public static int resolution_width;
        public static int resolution_height;
        public static System.Drawing.Bitmap bitmap;
        public static System.Drawing.Graphics graphics;
        public static System.Drawing.Color backColor;
        public static System.Windows.Forms.PictureBox display;

        public static void graph_init(System.Windows.Forms.PictureBox T)
        {
            display = T;
            resolution_width = display.Width;
            resolution_height = display.Height;
            backColor = System.Drawing.Color.LightBlue;
            bitmap = new System.Drawing.Bitmap(resolution_width, resolution_height);
            graphics = System.Drawing.Graphics.FromImage(bitmap);
            graph_clear();
            graph_refresh();
        }

        public static void graph_clear()
        {
            graphics.Clear(backColor);
        }

        public static void graph_refresh()
        {
            display.Image = bitmap;
        }

        public static void drawPoint(PointF A, Color fillColor, Color drawColor, int radius)
        {
            Pen draw = new Pen(drawColor);
            SolidBrush fill = new SolidBrush(fillColor);
            graphics.FillEllipse(fill, A.X - radius, A.Y - radius, radius * 2 + 1, radius * 2 + 1);
            graphics.DrawEllipse(draw, A.X - radius, A.Y - radius, radius * 2 + 1, radius * 2 + 1);
        }
    }
}
