using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication6
{
    public static partial class Engine
    {
        #region Random
        public static Random rnd = new Random();
        public static PointF getRNDPoint() 
        {
            float X = rnd.Next(myGraphics.resolution_width);
            float Y = rnd.Next(myGraphics.resolution_height);
            return new PointF(X, Y);
        }
        #endregion

        #region app

        #endregion
    }
}
