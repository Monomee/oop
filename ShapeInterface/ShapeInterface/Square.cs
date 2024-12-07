﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterface
{
    public class Square : Rectangle, Resizeable, IColorable
    {
        public Square()
        {
        }

        public Square(double side) : base(side, side)
        {
        }

        public Square(double side, string color, bool filled) : base(side, side, color, filled)
        {
        }

        public double getSide()
        {
            return getWidth();
        }

        public void setSide(double side)
        {
            base.setWidth(side);
            base.setLength(side);
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
            return "A Square with side="
                    + getSide()
                    + ", which is a subclass of "
                    + base.ToString();
        }

        public void Resize(double percent)
        {
            double newSize = getSide() * (1 + percent/100);
            setSide(newSize);
        }

        public void HowToColor()
        {
            Console.WriteLine("Color all four sides.");
        }
    }
}
