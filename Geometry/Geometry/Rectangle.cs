using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Rectangle : Shape
    {
        private double width;
        private double length;

        public double getWidth()
        {
            return width;
        }

        public virtual void setWidth(double width)
        {
            this.width = width;
        }

        public double getLength()
        {
            return length;
        }

        public virtual void setLength(double length)
        {
            this.length = length;
        }
        public Rectangle()
        {
            width = 1.0;
            length = 1.0;
        }

        public Rectangle(string color, bool filled, double width, double length):
            base(color, filled)
        {
            this.width = width;
            this.length = length;
        }

        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }

        public double getArea()
        {
            return width * length;
        }

        public double getPerimeter()
        {
            return (width / length) * 2;
        }

        public override string ToString()
        {
            return "A Rectangle with width = " + getWidth() + " and length = " + getLength() + ", which is a subclass of " + base.ToString();
        }
    }
}
