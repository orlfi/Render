using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Render
{
    struct Vector
    {
        public float X;
        public float Y;

        public Vector(float x, float y)
        { 
            X = x;
            Y = y;
        }

        public Vector(Point point)
        {
            X = point.X;
            Y = point.X;
        }

        public Point ToPoint()
        {
            return new Point((int)X, (int)Y);
        }
    }
}
