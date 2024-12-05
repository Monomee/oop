using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Circle : Shape
    {
        private double radius;

        public double Radius { get => radius; set => radius = value; }

        public Circle()
        {
            radius = 1.0;
        }

        public Circle(string color, bool filled, double radius) :
            base(color, filled)
            {
                this.radius = radius;
            }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double getArea()
        {
            return radius * radius * Math.PI;
        }

        public double getPerimeter()
        {
            return radius * 2 * Math.PI;
        }

        public override string ToString()
        {
            return "A Circle with radius = "+ Radius +", which is a subclass of " + base.ToString();
        }
    }
}
