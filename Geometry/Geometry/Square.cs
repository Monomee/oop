using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Square : Rectangle
    {
        public Square()
        {
        }

        public Square(double side) : base(side, side)
        {

        }

        public Square(string color, bool filled, double side) : base(color, filled, side, side)
        {
        }

        public double getSide()
        {
            return getWidth();
        }

        public void setSide(double side)
        {
            setWidth(side);
            setLength(side);
        }

        public override void setWidth(double width)
        {
            setSide(width);
        }

        public override void setLength(double length)
        {
            setSide(length);
        }

        public override string ToString()
        {
            return "A Square with side = " + getSide() + ", which is a subclass of " + base.ToString();
        }
    }
}
