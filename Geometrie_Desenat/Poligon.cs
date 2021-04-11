﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication6
{
    public class Poligon
    {

        public PointF[] points;
        public Color drawColor;
        public Poligon(int no_of_points)
        {
            points = new PointF[no_of_points];
            for (int i = 0; i < no_of_points; i++)
                points[i] = Engine.getRNDPoint();
        }
        public Poligon(PointF[] points)
        {
            this.points = new PointF[points.Length];
            for (int i = 0; i < points.Length; i++)
                this.points[i] = new PointF(points[i].X, points[i].Y);
        }
        public void draw(Graphics grp) 
        {
            grp.DrawPolygon(new Pen (drawColor), points);
            for (int i = 0; i < points.Length; i++)
            {
                myGraphics.drawPoint(points[i], drawColor, Color.Black, 1);
            }
        }

        public float area() 
        {
            float s = 0;
            for (int i = 0; i < points.Length - 1; i++)
                s += points[i].X * points[i + 1].Y - points[i + 1].X * points[i].Y;
            s += points[points.Length - 1].X * points[0].Y - points[points.Length - 1].Y * points[0].X;
            return (float)Math.Abs(0.5 * s);
        }

        public PointF cg ()
        {
            float X = 0;
            float Y = 0;
            for (int i = 0; i < points.Length; i++)
            {
                X += points[i].X;
                Y += points[i].Y;
            }
            return new PointF(X / points.Length, Y / points.Length);
        }
    }
}
