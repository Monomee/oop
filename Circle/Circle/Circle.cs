using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class Circle
    {
        private double radius;
        private string color;

        public Circle() { }

        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }

        public double Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }

        public double getArea()
        {
            return Radius * Radius * Math.PI;
        }

    }
}
