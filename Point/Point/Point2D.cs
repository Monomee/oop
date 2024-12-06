using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    public class Point2D
    {
        private float x = 0.0f;
        private float y = 0.0f;

        public Point2D()
        {
        }

        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }

        public void SetXY(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float[] GetXY()
        {
            return new float[] { X, Y };
        }

        public override string ToString()
        {
            return X +", " + Y;
        }
    }
}
