using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class Cylinder : Circle
    {
        private double height;

        public Cylinder()
        {
        }

        public Cylinder(double height)
        {
            this.height = height;
        }

        public Cylinder(double radius, string color, double height) : base(radius, color)
        {
            this.height = height;
        }

        public double Height { get => height; set => height = value; }

        public double getVolumn()
        {
            return base.getArea() * Height;
        }
    }
}
