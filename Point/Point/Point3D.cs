using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    public class Point3D : Point2D
    {
        private float z = 0.0f;

        public Point3D()
        {
        }

        public Point3D(float x, float y) : base(x,y) 
        {
        }

        public float Z { get => z; set => z = value; }
        
        public void SetXYZ(float x, float y, float z)
        {
            X = x; Y = y;
            this.z = z;
        }

        public float[] GetXYZ()
        {
            return new float[] { X, Y, Z };
        }

        public override string ToString()
        {
            return base.ToString() + ", " + Z;
        }
    }
}
