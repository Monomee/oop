using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Shape
    {
        private string color;
        private bool filled;

        public Shape()
        {
            color = "green";
            filled = true;
        }

        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public string Color { get => color; set => color = value; }
        public bool Filled { get => filled; set => filled = value; }

        public override string ToString()
        {
            return "A Shape with color of " + Color + " and " + ((Filled) ? "filled" : "not filled");
        }
    }
}
